using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Common.Logging;

using RestSharp;

using ThreeSeventy.Vector.Client.Models;
using ThreeSeventy.Vector.Client.Utils;

namespace ThreeSeventy.Vector.Client
{
    /// <summary>
    /// The TrueDialog REST context.
    /// </summary>
    /// <remarks>
    /// Specific implementation of RestContext
    /// </remarks>
    public class T70Context : RestContext
    {
        private const string KEYWORD_ATTACH_URI = "/account/{accountId}/channel/{channelId}/keyword/{keywordId}/campaign";

        private const string CONTACT_SEARCH_URI = "/account/{accountId}/contact-search/";

        private const string ACCOUNT_ATTRIBUTE_URI = "/account/{accountId}/attribute/{name}";

        private const string USER_CHAT_TOKEN_URI = "/chattoken";

        private const string USER_LOCK_URI = "/account/{accountId}/user/{username}/lock";

        private const string CONTACT_ATTRIBUTE_URI = "/account/{accountId}/contact/{contactId}/attribute/{name}";

        private const string CONTACT_IMPORT_TEMPLATE = "/account/{accountId}/contact-importtemplate";

        private const string KEYWORD_URI = "/account/{accountId}/keyword?onlyMine={onlyMine}";

        private const string LONGCODE_URL = "/account/{accountId}/long-code";

        private const string CAMPAIGN_KEYWORDS_URI = "/account/{accountId}/campaign/{campaignId}/keywords";

        private const string KEYWORD_CAMPAIGN_URI = "/account/{accountId}/channel/{channel}/keyword/{keyword}/campaign";

        private readonly ILog m_log = LogManager.GetLogger(typeof(T70Context));

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="config">Configuration details</param>
        /// <param name="clientFactory">The IRestClientFactory implementation to use (OPTIONAL)</param>
        public T70Context(IConfiguration config, IRestClientFactory clientFactory = null)
            : base(config, clientFactory)
        {
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <remarks>
        /// This will setup a T70Context which hits production.
        /// </remarks>
        public T70Context(IRestClientFactory clientFactory = null)
            : this(VectorConfigSection.GetConfig(), clientFactory)
        {
        }

        /// <summary>
        /// Sets up the model for the TrueDialog REST clients.
        /// </summary>
        /// <param name="modelBuilder">The model building configuration object.</param>
        override protected void OnModelCreating(RestModelBuilder modelBuilder)
        {

            UserSetup(modelBuilder);

            UserChatTokenSetup(modelBuilder);

            UserPasswordSetup(modelBuilder);

            AccountSetup(modelBuilder);

            AccountAttributeSetup(modelBuilder);

            AccountAttributeCategorySetup(modelBuilder);

            AccountAttributeDefinitionSetup(modelBuilder);

            ApiKeySetup(modelBuilder);

            ContactSetup(modelBuilder);

            ContentSetup(modelBuilder);

            SubscriptionSetup(modelBuilder);

            SubscriptionContactSetup(modelBuilder);

            CampaignSetup(modelBuilder);

            KeywordSetup(modelBuilder);

            KeywordContactSetup(modelBuilder);

            ActionSetup(modelBuilder);

            ActionPushSetup(modelBuilder);

            ActionExecuteSetup(modelBuilder);

            ActionScheduleSetup(modelBuilder);

            CallbackSetup(modelBuilder);

            ActionKeywordSetup(modelBuilder);

            CallForwardSetup(modelBuilder);

            CallForwardVerificationSetup(modelBuilder);

            CallHistorySetup(modelBuilder);

            ChatConversationLogSetup(modelBuilder);

            ChatMessageLogSetup(modelBuilder);

            ActionImportContactsSetup(modelBuilder);

            ContactAttributeSetup(modelBuilder);

            ContactAttributeCategorySetup(modelBuilder);

            ContactAttributeDefinitionSetup(modelBuilder);

            ContactKeywordSetup(modelBuilder);

            ContactSubscriptionSetup(modelBuilder);

            ChannelSetup(modelBuilder);

            RequestTnSetup(modelBuilder);

            SearchTnSetup(modelBuilder);

            CouponOfferSetup(modelBuilder);

            ExternalCouponListSetup(modelBuilder);

            CampaignChatSetup(modelBuilder);

            CampaignDialogSetup(modelBuilder);

            CampaignQuestionAnswerDefinitionSetup(modelBuilder);

            LinkSetup(modelBuilder);

            m_log.Trace("Model setup");
        }

        #region Model Setup

        private static void UserSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .UriFormat("account/{accountId}/user/{username}")
                ;

            modelBuilder.Entity<User>()
                .Property(c => c.UserName)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("username")
                ;

            modelBuilder.Entity<User>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }

        private static void UserChatTokenSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserChatToken>()
                .UriFormat("/chattoken/{accountId}")
            ;

            modelBuilder.Entity<UserChatToken>()
                .Property(a => a.AccountId)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("accountId")
            ;

        }


        private static void UserPasswordSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPassword>()
                .UriFormat("/account/{accountId}/user/{userName}/password")
                ;

            modelBuilder.Entity<UserPassword>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;

            modelBuilder.Entity<UserPassword>()
                .Property(c => c.UserName)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("username")
                ;

        }

        private static void AccountSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .UriFormat("/account/{accountId}")
            ;

            modelBuilder.Entity<Account>()
                .Property(a => a.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("accountId")
            ;
        }

        private static void AccountAttributeSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountAttribute>()
                .UriFormat("/account/{accountId}/attribute/{name}")
                ;

            modelBuilder.Entity<AccountAttribute>()
                .Property(c => c.Name)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("name")
                ;

            modelBuilder.Entity<AccountAttribute>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }


        private static void AccountAttributeCategorySetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountAttributeCategory>()
                .UriFormat("/reference/account-attribute-category/{categoryId}")
                ;

            modelBuilder.Entity<AccountAttributeCategory>()
                .Property(c => c.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("categoryId")
                ;
        }
        

     private static void AccountAttributeDefinitionSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountAttributeDefinition>()
                .UriFormat("/account/{accountId}/attributeDef/{attribDefId}")
                ;

            modelBuilder.Entity<AccountAttributeDefinition>()
                .Property(c => c.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("attribDefId")
                ;

            modelBuilder.Entity<AccountAttributeDefinition>()
             .Property(c => c.AccountId)
             .UrlSegment()
             .MapTo("accountId")
             ;
        }

        

         private static void ApiKeySetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApiKey>()
                .UriFormat("/account/{accountId}/api-key/{keyId}")
                ;

            modelBuilder.Entity<ApiKey>()
                .Property(c => c.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("keyId")
                ;

            modelBuilder.Entity<ApiKey>()
             .Property(c => c.AccountId)
             .UrlSegment()
             .MapTo("accountId")
             ;
        }

        private static void ContactSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .UriFormat("/account/{accountId}/contact/{contactId}")
            ;

            modelBuilder.Entity<Contact>()
                .Property(c => c.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("contactId")
            ;

            modelBuilder.Entity<Contact>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
            ;
        }


        private static void ContactAttributeSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactAttribute>()
                .UriFormat("/account/{accountId}/contact/{contactId}/attribute/{name}")
                ;

            modelBuilder.Entity<ContactAttribute>()
                .Property(c => c.Name)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("name")
                ;

            modelBuilder.Entity<ContactAttribute>()
                .Property(c => c.ContactId)
                .OptionalUrlSegment()
                .MapTo("contactId")
                ;

            modelBuilder.Entity<ContactAttribute>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }

        private static void ContactKeywordSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactKeyword>()
                .UriFormat("account/{accountId}/contact/{contactId}/keyword/{keywordId}")
                ;


            modelBuilder.Entity<ContactKeyword>()
                .Property(c => c.KeywordId)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("keywordId")
                ;

            modelBuilder.Entity<ContactKeyword>()
                .Property(c => c.ContactId)
                .OptionalUrlSegment()
                .MapTo("contactId")
                ;

            modelBuilder.Entity<ContactKeyword>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }

        private static void ContactAttributeCategorySetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactAttributeCategory>()
                .UriFormat("/reference/contact-attribute-category/{categoryId}")
                ;

            modelBuilder.Entity<ContactAttributeCategory>()
                .Property(c => c.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("categoryId")
                ;
        }


        private static void ContactAttributeDefinitionSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactAttributeDefinition>()
                           .UriFormat("/account/{accountId}/contact-attributeDef/{attribDefId}")
                           ;

            modelBuilder.Entity<ContactAttributeDefinition>()
                .Property(c => c.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("attribDefId")
                ;

            modelBuilder.Entity<ContactAttributeDefinition>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }

        private static void ContentSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Content>()
                .UriFormat("/account/{accountId}/content/{contentId}")
            ;

            modelBuilder.Entity<Content>()
                .Property(a => a.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("contentId")
            ;

            modelBuilder.Entity<Content>()
                .Property(a => a.AccountId)
                .UrlSegment()
                .MapTo("accountId")
            ;

            modelBuilder.Entity<ContentTemplate>()
                .UriFormat("/account/{accountId}/content/{contentId}/template/{templateId}")
            ;

            modelBuilder.Entity<ContentTemplate>()
                .Property(a => a.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("templateId")
            ;

            modelBuilder.Entity<ContentTemplate>()
                .Property(a => a.ContentId)
                .UrlSegment()
                .MapTo("contentId")
            ;

            modelBuilder.Entity<ContentTemplate>()
                .Property(a => a.AccountId)
                .UrlSegment()
                .MapTo("accountId")
            ;
        }

        private static void SubscriptionSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subscription>()
                .UriFormat("/account/{accountId}/subscription/{subscriptionId}")
                ;

            modelBuilder.Entity<Subscription>()
                .Property(s => s.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("subscriptionId")
            ;

            modelBuilder.Entity<Subscription>()
                .Property(s => s.AccountId)
                .UrlSegment()
                .MapTo("accountId")
            ;
        }

        private static void SubscriptionContactSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubscriptionContact>()
                .UriFormat("/account/{accountId}/subscription/{subscriptionId}/contact/{contactId}")
                ;

            modelBuilder.Entity<SubscriptionContact>()
                .Property(s => s.SubscriptionId)
                .OptionalUrlSegment()
                .MapTo("subscriptionId")
                ;

            modelBuilder.Entity<SubscriptionContact>()
                .Property(s => s.ContactId)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("contactId")
                ;

            modelBuilder.Entity<SubscriptionContact>()
                .Property(s => s.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }

        private static void CampaignSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campaign>()
                .UriFormat("/account/{accountId}/campaign/{campaignId}")
            ;

            modelBuilder.Entity<Campaign>()
                .Property(c => c.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("campaignId")
            ;

            modelBuilder.Entity<Campaign>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
            ;
        }

        private static void KeywordSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Keyword>()
                .UriFormat("/account/{accountId}/channel/{channelId}/keyword/{keywordId}")
            ;

            modelBuilder.Entity<Keyword>()
                .Property(k => k.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("keywordId")
            ;

            modelBuilder.Entity<Keyword>()
                .Property(k => k.ChannelId)
                .UrlSegment()
                .MapTo("channelId")
            ;

            modelBuilder.Entity<Keyword>()
                .Property(k => k.AccountId)
                .UrlSegment()
                .MapTo("accountId")
            ;
        }



        private static void KeywordContactSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KeywordContact>()
                .UriFormat("/account/{accountId}/keyword/{keywordId}/contact")
            ;

            modelBuilder.Entity<KeywordContact>()
                .Property(k => k.KeywordId)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("keywordId")
            ;


            modelBuilder.Entity<KeywordContact>()
                .Property(k => k.AccountId)
                .UrlSegment()
                .MapTo("accountId")
            ;
        }


        private static void ActionSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ThreeSeventy.Vector.Client.Models.Action>()
                .UriFormat("/account/{accountId}/action/{actionId}")
            ;

            modelBuilder.Entity<ThreeSeventy.Vector.Client.Models.Action>()
                .Property(e => e.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("actionId")
            ;

            modelBuilder.Entity<ThreeSeventy.Vector.Client.Models.Action>()
                .Property(e => e.AccountId)
                .UrlSegment()
                .MapTo("accountId")
            ;
        }

        private static void ActionPushSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionPushCampaign>()
                .UriFormat("/account/{accountId}/action-pushCampaign/{actionId}")
            ;

            modelBuilder.Entity<ActionPushCampaign>()
                .Property(e => e.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("actionId")
            ;

            modelBuilder.Entity<ActionPushCampaign>()
                .Property(e => e.AccountId)
                .UrlSegment()
                .MapTo("accountId")
            ;
        }

        private static void ActionKeywordSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionAttachKeyword>()
                .UriFormat("/account/{accountId}/action-attachKeyword/{actionId}")
            ;

            modelBuilder.Entity<ActionAttachKeyword>()
                .Property(e => e.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("actionId")
            ;

            modelBuilder.Entity<ActionAttachKeyword>()
                .Property(e => e.AccountId)
                .UrlSegment()
                .MapTo("accountId")
            ;
        }

        private static void ActionScheduleSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionSchedule>()
                .UriFormat("/account/{accountId}/action/{actionId}/schedule/{scheduleId}")
                ;

            modelBuilder.Entity<ActionSchedule>()
              .Property(e => e.ActionId)
              .UrlSegment()
              .MapTo("actionId")
              ;

            modelBuilder.Entity<ActionSchedule>()
                .Property(e => e.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("scheduleId")
                ;

            modelBuilder.Entity<ActionSchedule>()
                .Property(e => e.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }

        private static void ActionExecuteSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionExecute>()
                .UriFormat("/account/{accountId}/action/{actionId}/execute/{executeId}")
                ;

            modelBuilder.Entity<ActionExecute>()
                .Property(e => e.ActionId)
                .UrlSegment()
                .MapTo("actionId")
                ;

            modelBuilder.Entity<ActionExecute>()
                .Property(e => e.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("executeId")
                ;

            modelBuilder.Entity<ActionExecute>()
                .Property(e => e.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }

        private static void CallbackSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Callback>()
                .UriFormat("/account/{accountId}/callback/{callbackId}")
            ;

            modelBuilder.Entity<Callback>()
                .Property(c => c.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("callbackId")
            ;

            modelBuilder.Entity<Callback>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
            ;
        }


        private static void CallForwardSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CallForward>()
                .UriFormat("/account/{accountId}/long-code/{longCode}/callforwarding")
                ;

            modelBuilder.Entity<CallForward>()
                .Property(c => c.Code)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("longCode")
                ;

            modelBuilder.Entity<CallForward>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }


        private static void CallForwardVerificationSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CallForwardVerification>()
                .UriFormat("/account/{accountId}/long-code/{longCode}/callforwardingverification")
                ;

            modelBuilder.Entity<CallForwardVerification>()
                .Property(c => c.Code)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("longCode")
                ;

            modelBuilder.Entity<CallForwardVerification>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }


        private static void CallHistorySetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CallHistory>()
                .UriFormat("/account/{accountId}/chat/history")
                ;


            modelBuilder.Entity<CallHistory>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .PrimaryKey()
                .MapTo("accountId")
                ;
        }


        private static void ChatConversationLogSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatConversationLog>()
                .UriFormat("/account/{accountId}/chat/conversation/{conversationId}")
                ;

            modelBuilder.Entity<ChatConversationLog>()
           .Property(c => c.ConversationId)
           .OptionalUrlSegment()
           .PrimaryKey()
           .MapTo("conversationId")
           ;


            modelBuilder.Entity<ChatConversationLog>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }


        private static void ChatMessageLogSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatMessageLog>()
                .UriFormat("/account/{accountId}/chat/conversation/{conversationId}")
                ;


            modelBuilder.Entity<ChatMessageLog>()
                .Property(c => c.ConversationId)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("conversationId")
                ;

            modelBuilder.Entity<ChatMessageLog>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }


        private static void ActionImportContactsSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionImportContacts>()
               .UriFormat("/account/{accountId}/action-importContacts/{actionId}")
               ;


            modelBuilder.Entity<ActionImportContacts>()
                .Property(c => c.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("actionId")
                ;

            modelBuilder.Entity<ActionImportContacts>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }


        private static void ContactSubscriptionSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactSubscription>()
                .UriFormat("/account/{accountId}/contact/{contactId}/subscription/{subscriptionId}")
                ;

            modelBuilder.Entity<ContactSubscription>()
                .Property(c => c.ContactId)
                .OptionalUrlSegment()
                .MapTo("contactId")
                ;

            modelBuilder.Entity<ContactSubscription>()
                .Property(c => c.SubscriptionId)
                .OptionalUrlSegment()
                 .PrimaryKey()
                .MapTo("subscriptionId")
                ;

            modelBuilder.Entity<ContactSubscription>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }


        private static void ChannelSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Channel>()
                .UriFormat("/account/{accountId}/channel/{channel}")
                ;

            modelBuilder.Entity<Channel>()
                .Property(c => c.Id)
                .OptionalUrlSegment()
                 .PrimaryKey()
                .MapTo("channel")
                ;

            modelBuilder.Entity<Channel>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }


        private static void RequestTnSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequestTn>()
                .UriFormat("/account/{accountId}/request-tn/{requestId}")
                ;

            modelBuilder.Entity<RequestTn>()
                .Property(c => c.Id)
                .OptionalUrlSegment()
                 .PrimaryKey()
                .MapTo("requestId")
                ;

            modelBuilder.Entity<RequestTn>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }



        private static void SearchTnSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SearchTn>()
                .UriFormat("/account/{accountId}/search-for-tn/{searchId}")
                ;

            modelBuilder.Entity<SearchTn>()
                .Property(c => c.Id)
                .OptionalUrlSegment()
                 .PrimaryKey()
                .MapTo("searchId")
                ;

            modelBuilder.Entity<SearchTn>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }



        private static void CouponOfferSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CouponOffer>()
                .UriFormat("/account/{accountId}/campaign/{campaignId}/coupon")
                ;

            modelBuilder.Entity<CouponOffer>()
                .Property(c => c.CampaignId)
                .OptionalUrlSegment()
                 .PrimaryKey()
                .MapTo("campaignId")
                ;

            modelBuilder.Entity<CouponOffer>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }




        private static void ExternalCouponListSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExternalCouponList>()
                .UriFormat("/account/{accountId}/external-couponlist/{externalCouponListId}")
                ;

            modelBuilder.Entity<ExternalCouponList>()
                .Property(c => c.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("externalCouponListId")
                ;

            modelBuilder.Entity<ExternalCouponList>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }

        private static void CampaignChatSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CampaignChat>()
                .UriFormat("/account/{accountId}/campaign/{campaignId}/chat")
                ;

            modelBuilder.Entity<CampaignChat>()
                .Property(c => c.CampaignId)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("campaignId")
                ;

            modelBuilder.Entity<CampaignChat>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }

        private static void CampaignDialogSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CampaignDialog>()
                .UriFormat("/account/{accountId}/campaign/{campaignId}/dialog")
                ;

            modelBuilder.Entity<CampaignDialog>()
                .Property(c => c.CampaignId)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("campaignId")
                ;

            modelBuilder.Entity<CampaignDialog>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }


        private static void CampaignQuestionAnswerDefinitionSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CampaignQuestionAnswerDefinition>()
                .UriFormat("/account/{accountId}/campaign/{campaignId}/question/answer/{answerId}")
                ;

            modelBuilder.Entity<CampaignQuestionAnswerDefinition>()
                .Property(c => c.CampaignId)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("campaignId")
                ;

            modelBuilder.Entity<CampaignQuestionAnswerDefinition>()
                .Property(c => c.AnswerId)
                .OptionalUrlSegment()
                .MapTo("answerId")
                ;


            modelBuilder.Entity<CampaignQuestionAnswerDefinition>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }

        private static void LinkSetup(RestModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Link>()
                .UriFormat("/account/{accountId}/link/{linkId}")
                ;

            modelBuilder.Entity<Link>()
                .Property(c => c.Id)
                .OptionalUrlSegment()
                .PrimaryKey()
                .MapTo("linkId")
                ;


            modelBuilder.Entity<Link>()
                .Property(c => c.AccountId)
                .UrlSegment()
                .MapTo("accountId")
                ;
        }


        #endregion Model Setup

        #region Utility Function Support

        protected void Execute(IRestRequest request)
        {
            var client = GetClient();

            Uri uri = client.BuildUri(request);

            m_log.Trace(m => m("Performing {0} request: {1}", request.Method, uri));

            client.ExecuteRequestFor(
                GetRetryPolicy(),
                request,
                false);
        }

        protected TEntity Execute<TEntity>(IRestRequest request)
            where TEntity : class, new()
        {
            var client = GetClient();

            Uri uri = client.BuildUri(request);

            m_log.Trace(m => m("Performing {0} request: {1}", request.Method, uri));

            var response = client.ExecuteRequestFor(
                GetRetryPolicy(),
                request,
                false);

            return response.Deserialize<TEntity>();
        }

        #endregion Utility Function Support

        #region Utility Functions

        // These functions are for performing operations which have REST data that do not map well to a strict model.

        /// <summary>
        /// Provides a way to attach (or detach) a keyword to (from) a campaign.
        /// </summary>
        /// <param name="keyword">The keyword to attach (or detach)</param>
        /// <param name="campaignId">The ID of the campaign to attach to (NULL to detach the keyword)</param>
        public void AttachKeywordTo(Keyword keyword, int? campaignId)
        {
            if (keyword == null)
                throw new ArgumentNullException("keyword");
            
            IRestRequest request;

            if (!campaignId.HasValue)
            {
                request = new RestRequest(KEYWORD_ATTACH_URI, Method.DELETE)
                {
                    RequestFormat = DataFormat.Json,
                    JsonSerializer = new NewtonsoftSerializer()
                };
            }
            else
            {
                request = new RestRequest(KEYWORD_ATTACH_URI, Method.POST)
                {
                    RequestFormat = DataFormat.Json,
                    JsonSerializer = new NewtonsoftSerializer()
                };

                request.AddBody(campaignId.Value);
            }

            request.AddUrlSegment("keywordId", keyword.Id.ToString());
            request.AddUrlSegment("channelId", keyword.ChannelId.ToString());
            request.AddUrlSegment("accountId", keyword.AccountId.ToString());

            Execute(request);
        }

        /// <summary>
        /// Searches for a contact via a wild card pattern.
        /// </summary>
        /// <remarks>
        /// This provides a way to search for a contact via a wild card which will
        /// match to a PhoneNumber or Email address.
        /// 
        /// This method is more efficient than attempting to filter on the list of all 
        /// contacts returned by GetAll(), as this will preform a server side search.
        /// 
        /// Contacts returned by this endpoint will not contain their subscription
        /// information or attributes.
        /// </remarks>
        /// <param name="accountId">The account to search under.</param>
        /// <param name="wildcard">The wild card pattern to apply.</param>
        /// <returns>A list of contacts</returns>
        public IQueryable<Contact> ContactSearch(int accountId, string wildcard)
        {
            var request = new RestRequest(CONTACT_SEARCH_URI, Method.POST)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };

            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddBody(wildcard);

            var res = Execute<List<Contact>>(request) ?? new List<Contact>();

            // TODO: Map a flattened contact to an unflattened one.

            return res.AsQueryable();
        }


        /// <summary>
        /// Get the Account Attribute 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="name"></param>
        /// <returns></returns>

        public string GetAccountAttribute(int accountId, string name)
        {
            var request = new RestRequest(ACCOUNT_ATTRIBUTE_URI, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };

            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("name", name);

            var res = Execute<object>(request) ?? "";

            // TODO: Map a flattened contact to an unflattened one.

            return res.ToString();
        }


        /// <summary>
        /// POST the Account Attribute value 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="name"></param>
        /// <returns></returns>

        public string SetAccountAttributeValue(int accountId, string name, string value)
        {
            var request = new RestRequest(ACCOUNT_ATTRIBUTE_URI, Method.PUT)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };

            request.AddBody(value);

            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("name", name);

            var res = Execute<object>(request) ?? "";

            // TODO: Map a flattened contact to an unflattened one.

            return res.ToString();
        }

        /// <summary>
        /// Gets the user chat token of the current user
        /// </summary>
        /// <returns></returns>
        public UserChatToken GetUSerChatToken()
        {
            var request = new RestRequest(USER_CHAT_TOKEN_URI, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            var res = Execute<UserChatToken>(request) ?? new UserChatToken();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }


        /// <summary>
        /// Locks a user's account preventing them from being able to login.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public string UserLock(int accountId, string userName)
        {
            var request = new RestRequest(USER_LOCK_URI, Method.POST)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("userName", userName);

            var res = Execute<object>(request) ?? "";

            // TODO: Map a flattened contact to an unflattened one.

            return res.ToString();
        }

        /// <summary>
        /// Removes the lock on a user allowing them to login again.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public string UnLockUser(int accountId, string userName)
        {
            var request = new RestRequest(USER_LOCK_URI, Method.PUT)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("userName", userName);

            var res = Execute<object>(request) ?? "";

            // TODO: Map a flattened contact to an unflattened one.

            return res.ToString();
        }


        /// <summary>
        /// Gets the value for a specific attribute.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="contactId"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetContactAttributeValue(int accountId, int contactId, string name)
        {
            var request = new RestRequest(CONTACT_ATTRIBUTE_URI, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };


            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("contactId", contactId.ToString());
            request.AddUrlSegment("name", name);

            var res = Execute<object>(request) ?? "";

            // TODO: Map a flattened contact to an unflattened one.

            return res.ToString();
        }

        /// <summary>
        /// Creates a specific attribute item on a contact.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="contactId"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string PostContactAttributeValue(int accountId, int contactId, string name, string value)
        {
            var request = new RestRequest(CONTACT_ATTRIBUTE_URI, Method.POST)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };

            request.AddBody(value);

            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("contactId", contactId.ToString());
            request.AddUrlSegment("name", name);

            var res = Execute<object>(request) ?? "";

            // TODO: Map a flattened contact to an unflattened one.

            return res.ToString();
        }


        /// <summary>
        /// Get contact import template file
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public string GetContactImportTemplate(int accountId)
        {
            var request = new RestRequest(CONTACT_IMPORT_TEMPLATE, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };
            request.AddUrlSegment("accountId", accountId.ToString());

            var res = Execute<object>(request) ?? "";

            // TODO: Map a flattened contact to an unflattened one.

            return res.ToString();
        }



        /// <summary>
        /// Get all the keywords for the account and its child 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="onlyMine"></param>
        /// <returns></returns>
        public List<Keyword> GetKeywords(int accountId, bool onlyMine)
        {
            var request = new RestRequest(KEYWORD_URI, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };
            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("onlyMine", onlyMine.ToString());

            var res = Execute<List<Keyword>>(request) ?? new List<Keyword>();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }

        /// <summary>
        /// Returns a list of usable long codes for the supplied account ID.
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public List<string> GetLongCodes(int accountId)
        {
            var request = new RestRequest(LONGCODE_URL, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };
            request.AddUrlSegment("accountId", accountId.ToString());

            var res = Execute<List<string>>(request) ?? new List<string>();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }

        /// <summary>
        /// Gets all keywords on a campaign.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="campaignId"></param>
        /// <returns></returns>
        public List<Keyword> GetCampaignKeywords(int accountId, int campaignId)
        {
            var request = new RestRequest(CAMPAIGN_KEYWORDS_URI, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };
            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("campaignId", accountId.ToString());

            var res = Execute<List<Keyword>>(request) ?? new List<Keyword>();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }


        /// <summary>
        /// Gets the campaign details of the specified keyword.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="channel"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public Campaign GetKeywordCampaign(int accountId, string channel, string keyword)
        {
            var request = new RestRequest(KEYWORD_CAMPAIGN_URI, Method.GET)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };
            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("channel", channel);
            request.AddUrlSegment("keyword", keyword);

            var res = Execute<Campaign>(request) ?? new Campaign();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }

/// <summary>
/// Attaches a keyword to a campaign.
/// </summary>
/// <param name="accountId"></param>
/// <param name="channel"></param>
/// <param name="keyword"></param>
/// <param name="campaignId"></param>
/// <returns></returns>
        public Keyword AttachkeywordCampaign(int accountId, string channel, string keyword, int campaignId)
        {
            var request = new RestRequest(KEYWORD_CAMPAIGN_URI, Method.POST)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };

            request.AddBody(campaignId);
            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("channel", channel);
            request.AddUrlSegment("keyword", keyword);

            var res = Execute<Keyword>(request) ?? new Keyword();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }


        /// <summary>
        ///  Remove Keyword Campaign
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="channel"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public HttpResponseMessage DettachkeywordCampaign(int accountId, string channel, string keyword)
        {
            var request = new RestRequest(KEYWORD_CAMPAIGN_URI, Method.DELETE)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new NewtonsoftSerializer()
            };

            request.AddUrlSegment("accountId", accountId.ToString());
            request.AddUrlSegment("channel", channel);
            request.AddUrlSegment("keyword", keyword);

            var res = Execute<HttpResponseMessage>(request) ?? new HttpResponseMessage();

            // TODO: Map a flattened contact to an unflattened one.

            return res;
        }
        #endregion Utility Functions
    }
}
