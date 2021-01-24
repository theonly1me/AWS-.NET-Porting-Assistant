using System;
using System.ComponentModel;
namespace DataTransmission
{
    /// <summary>
    /// Use for Database actions like insert , Update, Delete etc.
    /// </summary>
    [Flags]
    public enum DMLFlags
    {
        Insert = 1,
        Update = 2,
        SoftDelete = 3,
        Select = 4,
        SingleSelect = 5,
        Delete = 6,
        CombineSelect=7,
    }

    /// <summary>
    /// Use for Holding values of User type like Normal User,Admin etc.
    /// </summary>
    [Flags]
    public enum UserType
    {
        Normal = 1,
        Agent = 2,
        POS = 3,
        //Admin = 4,        used from Database
    }

    /// <summary>
    /// Use for Database actions like insert , Update, Delete etc.
    /// </summary>
    [Flags]
    public enum EventFlags
    {
        OnLoad = 1,
        Search = 2,
        Add = 3,
        Save = 4,
        Reset = 5,
        Cancel = 6,
        ViewResult = 7,
        OnLoadForEdit = 8,
        Catch=9,
        PersonalInfoLoad=10,
        OnspecificLoad=11,
        OnLoadForEditwithAddEnabled=12,
        OnMORec=13,
    }
    /// <summary>
    /// Use to choose personnel type like Officer , JCO , OR
    /// </summary>
    [Flags]
    public enum PERSTYPEFlags
    {
        Officer = 'F',
        JCO = 'J',
        OR = 'O',

    }

    public enum docSource
    {
        Dakin = 1,
        Draft = 2,
        Internal = 3,

    }

    public enum FolderType
    {
        Mailing = 1,
        DakBook = 2,
        ECabinate = 3,
        Personal = 4,
    }


    public enum SystemFolders
    {
        DakIn = 1,
        DakOut = 2,
        Inbox = 3,
        Draft = 4,
        SentItems = 5,
        Filing = 6,
        Compose = 7,
    }
   
    public enum Hasdak
    {
        Yes = 1,
        NO = 2,

    }

    //-------------------------Enum for Accounts System---------------

    public enum voucherTypeFlags
    {
        PaymentVoucher = 1,

        ReceiptVoucher = 2,

        ContraVoucher = 3,

        AdjustmentVoucher = 4,
    }

    //-------------------------------------------------------------



    //-------------------------Enum for Legal System---------------
    public enum place
    {
        CivilArea = 1,

        WithinUnit = 2,

        OtherUnit = 3,

    }

    public enum Known
    {
        Yes = 1,
        No = 2,

    }
    public enum plea
    {
        Guilty = 1,
        NotGuilty = 2,

    }

    public enum Rules
    {
        Rule4 = 1,
        Rule5 = 2,
        Rule45 = 3,
        NS=4
    }
 
    public enum Operations
    {
        IncidentDetails = 5,
        Accused = 6,
        Witness = 7,
        Question = 8,
        QuestionDetails = 9,
        ForwardToCo = 10,
        StatementCheck = 11,
        viewQuestion=12

    }

    public enum caseStatus
    {
        NewIncident = 1,
        CognizanceCompleted = 2,
        ConveningOrderGenerated = 3,
        CourtOfInquiry = 4,
        CaseFiled = 5,
        Hearing = 6,
        Chargesheet = 7,
        SummaryTrial = 8,
        SummaryofEvidence = 9,
        SCM = 10,
        Dismissed = 11,
        ReviewFromHigherAuthority = 12,
        PartOneOrderGenerated =13

    }

    public enum OperationType
    {
        New=1,
        Update=2,
        Delete=3,
        Purge=4,
        View=5,
        Track=6
    }


    public enum ArmyActsRules
    { 
        Rule180 =1,
        Rule125=2
    
    
    }

    public enum ConveningOperationType
    {
        New = 0,
        Update = 1,
        IssueAmmendments = 2,
        Generate = 3,
        Delete = 4,
        View=5
    }

    //------------------------------------------------------------------
    public enum OptionType
    {
        [Description("Posting In")]
        PostingIn = 1,

        [Description("From Adm")]
        FromAdm = 2,

        [Description("From Course")]
        FromCourse = 3,

        [Description("From Det")]
        FromDet = 4,

        [Description("From Hosp")]
        FromHosp = 5,

        [Description("From Leave")]
        FromLeave = 6,

        [Description("From Stn")]
        FromStn = 7,

        [Description("From TD")]
        FromTD = 8,

        [Description("From ERE")]
        FromERE = 9,

        [Description("To Adm")]
        ToAdm = 10,

        [Description("To Course")]
        ToCourse = 11,

        [Description("To Det")]
        ToDet = 12,

        [Description("To Hosp")]
        ToHosp = 13,

        [Description("To Leave")]
        ToLeave = 14,

        [Description("To Att")]
        ToAtt = 15,

        [Description("To TD")]
        ToTD = 16,

        [Description("To ERE")]
        ToERE = 17,

        [Description("Posting Out")]
        PostingOut = 18,

        [Description("RTU")]
        RTU = 19,



        [Description("Death")]
        Death = 21,

        [Description("Missing")]
        Missing = 22,

        [Description("On Att")]
        OnAtt = 25,

        [Description("On TD")]
        OnTD = 26,

        [Description("To AWL")]
        ToAWL = 23,

        [Description("Discharge")]
        Discharge = 35,
    }

    public enum LRC
    {
        With = 0,
        Without = 1,

    }
   

    /// <summary>
    /// Volume No
    /// </summary>
    public enum NewVolume
    {
        I = 1,
        II = 2,
        III = 3,
        IV = 4,
        V = 5,
        VI = 6,
        VII = 7,
        VIII = 8,
        IX = 9,
        X = 10,
        XI = 11,
        XII = 12,
        XIII = 13,
        XIV = 14,
        XV = 15,
        XVI = 16,
        XVII = 17,
        XVIII = 18,
        XIX = 19,
        XX = 20
    }
    public enum GeneralFlag
    {
        Open = 1,
        Close = 2,
        Pending = 3,
        Filed   = 4,
        Dispatch = 5,
        PreFiled   = 6,
        PreDispatch = 7
    }
    /// <summary>
    /// Volume State
    /// </summary>
    public enum VolumeState
    {
        Open = 1,
        Close = 2,
        Destroyed = 3
    }

    public enum CaseStage
    { 
      Incident=1,
      CaseFile=2
    
    }

    /// <summary>
    /// Use for Selecting Images for Messages.
    /// </summary>
    [Flags]
    public enum ImageforMessage
    {
        Info = 1,
        Alert = 2,
        
    }
}

