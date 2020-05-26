using System;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using Microsoft.Graph;
using Microsoft.Graph.Auth;
using TeamsDevOpsComms.Utilities;
using TestConginitiveService_TextAnalytics;

namespace TeamsDevOpsComms
{
    public partial class Main : Form
    {
        //Set the scope for API call to user.read
        string[] scopes = new string[] { "user.read", "group.readwrite.all" , "Team.ReadBasic.All", "Group.ReadWrite.All" };

        IPublicClientApplication publicClientApplication = null;
        InteractiveAuthenticationProvider graphAuthResult = null;
        GraphServiceClient graphClient = null;
        User user = null;

        private void InitializeApp()
        {
            ResponseText.Text = string.Empty;
            TokenDetails.Text = string.Empty;
            try
            {

                publicClientApplication = PublicClientApplicationBuilder
                    .Create(graphApp.ClientId)
                .WithAuthority(AzureCloudInstance.AzurePublic, graphApp.Tenant)
                .WithDefaultRedirectUri()
                .Build();

                graphAuthResult = new InteractiveAuthenticationProvider(publicClientApplication, scopes, Microsoft.Identity.Client.Prompt.SelectAccount, this);
            }
            catch (MsalException msalex)
            {
                ResponseText.Text = $"Error Acquiring Token:{System.Environment.NewLine}{msalex}";
            }

            cmdSignOn.Enabled = true;
            GetTeamsBtn.Enabled = false;

        }

        public Main()
        {
            InitializeComponent();
            InitializeApp();
        }

        private async void cmdSignOn_Click(object sender, EventArgs e)
        {
            if (graphAuthResult != null)
            {
                graphClient = new GraphServiceClient(graphAuthResult);

                user = await graphClient.Me
                    .Request()
                    .GetAsync();
                if (user != null)
                {
                    DisplayBasicUserInfo();
                    cmdSignOn.Enabled = false;
                    GetTeamsBtn.Enabled = true;
                    UpdateStatusLabel("Signed In...");
                }
            }
            else
            {
                TokenDetails.Text = "Unable to sign on.";
            }
        }

        /// <summary>
        /// Display basic information contained in the token
        /// </summary>
        private void DisplayBasicUserInfo()
        {
            TokenDetails.Text = "";
            if (user != null)
            {
                TokenDetails.Text += $"Username: {user.DisplayName}" + Environment.NewLine;
                TokenDetails.Text += $"Email: {user.Mail}" + Environment.NewLine;
            }
        }

        private void UpdateStatusLabel(string status)
        {
            StatusLabel.Text = status;
        }

        private async void GetTeamsBtn_Click(object sender, EventArgs e)
        {
            if (graphAuthResult != null)
            {
                user.JoinedTeams = await graphClient.Me.JoinedTeams
                       .Request()
                       .GetAsync();

                if (user.JoinedTeams.Count > 0)
                {
                    foreach (Team t in user.JoinedTeams)
                    {
                        var channels = await graphClient.Teams[t.Id].Channels
                                                    .Request()
                                                    .GetAsync();
                        t.Channels = channels;
                    }
                }
                PopulateTeamsTreeview();
            }
        }

        private void PopulateTeamsTreeview()
        {
            TeamsTreeView.Nodes.Clear();
            foreach (Team t in user.JoinedTeams)
            {
                var parent = new TreeNode(t.Description);
                foreach (Channel c in t.Channels)
                {
                    parent.Nodes.Add(t.Id + "^" + c.Id, c.DisplayName);
                }
                TeamsTreeView.Nodes.Add(parent);
            }
        }

        private void TeamsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var teamId = "";
            var channelId = "";
            if (e.Node.Level == 1)
            {
                var ids = e.Node.Name.ToString().Split('^');
                if (ids.Length == 2)
                {
                    teamId = ids[0];
                    channelId = ids[1];

                    GetChannelMessages(teamId, channelId);
                    //PopulateConversation(messages.Result);
                }
            }
        }

        private async void GetChannelMessages(string teamId, string channelId)
        {
            var messages = await graphClient.Teams[teamId].Channels[channelId].Messages
                                .Request()
                                .GetAsync();

            foreach (var m in messages)
            {
                m.Replies = await graphClient.Teams[teamId].Channels[channelId].Messages[m.Id].Replies
                    .Request()
                    .GetAsync();
            }
            PopulateConversation(messages);
        }

        private void PopulateConversation(IChannelMessagesCollectionPage messages)
        {
            ResponseText.Text = "";
            foreach (var m in messages)
            {
                ResponseText.Text += m.From.User.DisplayName + " wrote:" + Environment.NewLine;
                ResponseText.Text += Helper.ConvertHtmlToPlainText(m.Body.Content) + Environment.NewLine;
                foreach(var r in m.Replies)
                {
                    ResponseText.Text += "\t" + r.From.User.DisplayName + " replied:" + Environment.NewLine;
                    ResponseText.Text += "\t" + Helper.ConvertHtmlToPlainText(r.Body.Content) + Environment.NewLine;
                    ResponseText.Text += Environment.NewLine;
                }
                ResponseText.Text += Environment.NewLine;
            }
        }

        private void GetIncidentAndCreateTask_Click(object sender, EventArgs e)
        {

        }

        #region CognitiveServices

        #endregion CognitiveServices

        private async void btnSendText_Click(object sender, EventArgs e)
        {
            var id = "1";
            string text = InputBox.Text;
            if (!String.IsNullOrEmpty(text))
            {
                OutputBox.Text = "------Sentiment Analysis----------" + Environment.NewLine;
                 var sentimentTask = await SentimentAnalyser.AnalyzeSentimentAsync(id, text, "en");
                OutputBox.Text += sentimentTask + Environment.NewLine;
                OutputBox.Text += "------KeyPhrase Analysis----------" + Environment.NewLine;
                var keyphraseTask = await KeyPhraseAnalyser.AnalyzeKeyPhrases(id, text, "en");
                OutputBox.Text += keyphraseTask + Environment.NewLine;
            }
            else
                OutputBox.Text = "Please enter some text to analyse";
                
        }
    }
}
