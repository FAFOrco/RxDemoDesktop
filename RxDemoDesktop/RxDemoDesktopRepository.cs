﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace RxDemoDesktop
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the RxDemoDesktopRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("53ceb678-4ae7-4d4a-82dc-523221a01652")]
    public partial class RxDemoDesktopRepository : RepoGenBaseFolder
    {
        static RxDemoDesktopRepository instance = new RxDemoDesktopRepository();
        RxDemoDesktopRepositoryFolders.RxMainFrameAppFolder _rxmainframe;
        RxDemoDesktopRepositoryFolders.List1000AppFolder _list1000;

        /// <summary>
        /// Gets the singleton class instance representing the RxDemoDesktopRepository element repository.
        /// </summary>
        [RepositoryFolder("53ceb678-4ae7-4d4a-82dc-523221a01652")]
        public static RxDemoDesktopRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public RxDemoDesktopRepository() 
            : base("RxDemoDesktopRepository", "/", null, 0, false, "53ceb678-4ae7-4d4a-82dc-523221a01652", ".\\RepositoryImages\\RxDemoDesktopRepository53ceb678.rximgres")
        {
            _rxmainframe = new RxDemoDesktopRepositoryFolders.RxMainFrameAppFolder(this);
            _list1000 = new RxDemoDesktopRepositoryFolders.List1000AppFolder(this);
        }

#region Variables

        string _AREA = "Sales";

        /// <summary>
        /// Gets or sets the value of variable AREA.
        /// </summary>
        [TestVariable("d9ab43d0-4bef-44fc-8d2b-0f497eb3f347")]
        public string AREA
        {
            get { return _AREA; }
            set { _AREA = value; }
        }

        string _GENERO = "Male";

        /// <summary>
        /// Gets or sets the value of variable GENERO.
        /// </summary>
        [TestVariable("bdd4ae4c-fcda-4412-9e97-e917b8ac23d6")]
        public string GENERO
        {
            get { return _GENERO; }
            set { _GENERO = value; }
        }

        string _APELLIDO = "";

        /// <summary>
        /// Gets or sets the value of variable APELLIDO.
        /// </summary>
        [TestVariable("6fee93b2-180c-4617-b5aa-ca378f2a41ed")]
        public string APELLIDO
        {
            get { return _APELLIDO; }
            set { _APELLIDO = value; }
        }

        string _NOMBRE = "";

        /// <summary>
        /// Gets or sets the value of variable NOMBRE.
        /// </summary>
        [TestVariable("333f5d62-569c-4e67-a832-785e0035ca9e")]
        public string NOMBRE
        {
            get { return _NOMBRE; }
            set { _NOMBRE = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("53ceb678-4ae7-4d4a-82dc-523221a01652")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("deab196d-2298-450b-89bd-7e8e12fc3f06")]
        public virtual RxDemoDesktopRepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }

        /// <summary>
        /// The List1000 folder.
        /// </summary>
        [RepositoryFolder("6c27dd37-0aef-4318-8460-09f7f702922b")]
        public virtual RxDemoDesktopRepositoryFolders.List1000AppFolder List1000
        {
            get { return _list1000; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class RxDemoDesktopRepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("deab196d-2298-450b-89bd-7e8e12fc3f06")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RxDemoDesktopRepositoryFolders.RxTabStandardFolder _rxtabstandard;
            RepoItemInfo _testdatabaseInfo;
            RepoItemInfo _btnaddpersonInfo;
            RepoItemInfo _lblnumberofpersonsnumberInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@controlname='RxMainFrame']", parentFolder, 30000, null, true, "deab196d-2298-450b-89bd-7e8e12fc3f06", "")
            {
                _rxtabstandard = new RxDemoDesktopRepositoryFolders.RxTabStandardFolder(this);
                _testdatabaseInfo = new RepoItemInfo(this, "TestDatabase", "?/?/tabpage[@accessiblename='Test database' and @visible='true']", 30000, null, "b42cf2d9-c4b9-464e-ad4b-005e22c2557b");
                _btnaddpersonInfo = new RepoItemInfo(this, "BtnAddPerson", "?/?/tabpage[@controlname='RxTabStandard']/button[@controlname='btnAddPerson']", 30000, null, "075b51f5-1998-40bd-8aa1-b19a80696f4d");
                _lblnumberofpersonsnumberInfo = new RepoItemInfo(this, "LblNumberOfPersonsNumber", "?/?/tabpage[@controlname='RxTabStandard']/text[@controlname='lblNumberOfPersonsNumber']", 30000, null, "a96f4104-2bc8-433e-8929-0f601374973e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("deab196d-2298-450b-89bd-7e8e12fc3f06")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("deab196d-2298-450b-89bd-7e8e12fc3f06")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TestDatabase item.
            /// </summary>
            [RepositoryItem("b42cf2d9-c4b9-464e-ad4b-005e22c2557b")]
            public virtual Ranorex.TabPage TestDatabase
            {
                get
                {
                    return _testdatabaseInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The TestDatabase item info.
            /// </summary>
            [RepositoryItemInfo("b42cf2d9-c4b9-464e-ad4b-005e22c2557b")]
            public virtual RepoItemInfo TestDatabaseInfo
            {
                get
                {
                    return _testdatabaseInfo;
                }
            }

            /// <summary>
            /// The BtnAddPerson item.
            /// </summary>
            [RepositoryItem("075b51f5-1998-40bd-8aa1-b19a80696f4d")]
            public virtual Ranorex.Button BtnAddPerson
            {
                get
                {
                    return _btnaddpersonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnAddPerson item info.
            /// </summary>
            [RepositoryItemInfo("075b51f5-1998-40bd-8aa1-b19a80696f4d")]
            public virtual RepoItemInfo BtnAddPersonInfo
            {
                get
                {
                    return _btnaddpersonInfo;
                }
            }

            /// <summary>
            /// The LblNumberOfPersonsNumber item.
            /// </summary>
            [RepositoryItem("a96f4104-2bc8-433e-8929-0f601374973e")]
            public virtual Ranorex.Text LblNumberOfPersonsNumber
            {
                get
                {
                    return _lblnumberofpersonsnumberInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LblNumberOfPersonsNumber item info.
            /// </summary>
            [RepositoryItemInfo("a96f4104-2bc8-433e-8929-0f601374973e")]
            public virtual RepoItemInfo LblNumberOfPersonsNumberInfo
            {
                get
                {
                    return _lblnumberofpersonsnumberInfo;
                }
            }

            /// <summary>
            /// The RxTabStandard folder.
            /// </summary>
            [RepositoryFolder("2208919f-c341-4899-a250-684dc0d443f8")]
            public virtual RxDemoDesktopRepositoryFolders.RxTabStandardFolder RxTabStandard
            {
                get { return _rxtabstandard; }
            }
        }

        /// <summary>
        /// The RxTabStandardFolder folder.
        /// </summary>
        [RepositoryFolder("2208919f-c341-4899-a250-684dc0d443f8")]
        public partial class RxTabStandardFolder : RepoGenBaseFolder
        {
            RepoItemInfo _abrirInfo;
            RepoItemInfo _rdbgeneroInfo;
            RepoItemInfo _firstnameInfo;
            RepoItemInfo _lastnameInfo;
            RepoItemInfo _updowneditInfo;
            RepoItemInfo _rdbfemaleInfo;
            RepoItemInfo _db_personInfo;
            RepoItemInfo _btndeletepersonInfo;

            /// <summary>
            /// Creates a new RxTabStandard  folder.
            /// </summary>
            public RxTabStandardFolder(RepoGenBaseFolder parentFolder) :
                    base("RxTabStandard", "?/?/tabpage[@controlname='RxTabStandard']", parentFolder, 30000, null, false, "2208919f-c341-4899-a250-684dc0d443f8", "")
            {
                _abrirInfo = new RepoItemInfo(this, "Abrir", "?/?/button[@accessiblename='Abrir']", 30000, null, "84cbfce1-2e09-4595-8561-d940b9828eb4");
                _rdbgeneroInfo = new RepoItemInfo(this, "RdbGenero", "container[@controlname='grpGender']/radiobutton[@text=$GENERO]", 30000, null, "0cd049bb-2e5f-4790-b022-8ba0906ad272");
                _firstnameInfo = new RepoItemInfo(this, "FirstName", "?/?/text[@accessiblename='First name']", 30000, null, "8587941a-7952-4729-b258-82a12aa38bd9");
                _lastnameInfo = new RepoItemInfo(this, "LastName", "?/?/text[@accessiblename='Last name']", 30000, null, "a3e6a773-d90a-4c52-838c-f710ca610088");
                _updowneditInfo = new RepoItemInfo(this, "UpDownEdit", "?/?/text[@controlname='upDownEdit']", 30000, null, "28b9a8d8-941f-4d19-b11b-07e3d2f31c88");
                _rdbfemaleInfo = new RepoItemInfo(this, "RdbFemale", "?/?/radiobutton[@controlname='rdbFemale']", 30000, null, "c4045824-46f6-46c9-9845-f07de256cb8f");
                _db_personInfo = new RepoItemInfo(this, "db_Person", "list[@controlname='lstPersonList']/?/?/listitem[@accessiblename~$NOMBRE+' '+$APELLIDO]", 30000, null, "ba1a69ef-b1ba-4fb8-9b6c-02203335bf99");
                _btndeletepersonInfo = new RepoItemInfo(this, "BtnDeletePerson", "button[@controlname='btnDeletePerson']", 30000, null, "6ea801b2-eca1-4685-9a5c-c9fb5c02bf49");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("2208919f-c341-4899-a250-684dc0d443f8")]
            public virtual Ranorex.TabPage Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("2208919f-c341-4899-a250-684dc0d443f8")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Abrir item.
            /// </summary>
            [RepositoryItem("84cbfce1-2e09-4595-8561-d940b9828eb4")]
            public virtual Ranorex.Button Abrir
            {
                get
                {
                    return _abrirInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Abrir item info.
            /// </summary>
            [RepositoryItemInfo("84cbfce1-2e09-4595-8561-d940b9828eb4")]
            public virtual RepoItemInfo AbrirInfo
            {
                get
                {
                    return _abrirInfo;
                }
            }

            /// <summary>
            /// The RdbGenero item.
            /// </summary>
            [RepositoryItem("0cd049bb-2e5f-4790-b022-8ba0906ad272")]
            public virtual Ranorex.RadioButton RdbGenero
            {
                get
                {
                    return _rdbgeneroInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The RdbGenero item info.
            /// </summary>
            [RepositoryItemInfo("0cd049bb-2e5f-4790-b022-8ba0906ad272")]
            public virtual RepoItemInfo RdbGeneroInfo
            {
                get
                {
                    return _rdbgeneroInfo;
                }
            }

            /// <summary>
            /// The FirstName item.
            /// </summary>
            [RepositoryItem("8587941a-7952-4729-b258-82a12aa38bd9")]
            public virtual Ranorex.Text FirstName
            {
                get
                {
                    return _firstnameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The FirstName item info.
            /// </summary>
            [RepositoryItemInfo("8587941a-7952-4729-b258-82a12aa38bd9")]
            public virtual RepoItemInfo FirstNameInfo
            {
                get
                {
                    return _firstnameInfo;
                }
            }

            /// <summary>
            /// The LastName item.
            /// </summary>
            [RepositoryItem("a3e6a773-d90a-4c52-838c-f710ca610088")]
            public virtual Ranorex.Text LastName
            {
                get
                {
                    return _lastnameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LastName item info.
            /// </summary>
            [RepositoryItemInfo("a3e6a773-d90a-4c52-838c-f710ca610088")]
            public virtual RepoItemInfo LastNameInfo
            {
                get
                {
                    return _lastnameInfo;
                }
            }

            /// <summary>
            /// The UpDownEdit item.
            /// </summary>
            [RepositoryItem("28b9a8d8-941f-4d19-b11b-07e3d2f31c88")]
            public virtual Ranorex.Text UpDownEdit
            {
                get
                {
                    return _updowneditInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The UpDownEdit item info.
            /// </summary>
            [RepositoryItemInfo("28b9a8d8-941f-4d19-b11b-07e3d2f31c88")]
            public virtual RepoItemInfo UpDownEditInfo
            {
                get
                {
                    return _updowneditInfo;
                }
            }

            /// <summary>
            /// The RdbFemale item.
            /// </summary>
            [RepositoryItem("c4045824-46f6-46c9-9845-f07de256cb8f")]
            public virtual Ranorex.RadioButton RdbFemale
            {
                get
                {
                    return _rdbfemaleInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The RdbFemale item info.
            /// </summary>
            [RepositoryItemInfo("c4045824-46f6-46c9-9845-f07de256cb8f")]
            public virtual RepoItemInfo RdbFemaleInfo
            {
                get
                {
                    return _rdbfemaleInfo;
                }
            }

            /// <summary>
            /// The db_Person item.
            /// </summary>
            [RepositoryItem("ba1a69ef-b1ba-4fb8-9b6c-02203335bf99")]
            public virtual Ranorex.ListItem db_Person
            {
                get
                {
                    return _db_personInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The db_Person item info.
            /// </summary>
            [RepositoryItemInfo("ba1a69ef-b1ba-4fb8-9b6c-02203335bf99")]
            public virtual RepoItemInfo db_PersonInfo
            {
                get
                {
                    return _db_personInfo;
                }
            }

            /// <summary>
            /// The BtnDeletePerson item.
            /// </summary>
            [RepositoryItem("6ea801b2-eca1-4685-9a5c-c9fb5c02bf49")]
            public virtual Ranorex.Button BtnDeletePerson
            {
                get
                {
                    return _btndeletepersonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnDeletePerson item info.
            /// </summary>
            [RepositoryItemInfo("6ea801b2-eca1-4685-9a5c-c9fb5c02bf49")]
            public virtual RepoItemInfo BtnDeletePersonInfo
            {
                get
                {
                    return _btndeletepersonInfo;
                }
            }
        }

        /// <summary>
        /// The List1000AppFolder folder.
        /// </summary>
        [RepositoryFolder("6c27dd37-0aef-4318-8460-09f7f702922b")]
        public partial class List1000AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _salesInfo;
            RepoItemInfo _marketingInfo;

            /// <summary>
            /// Creates a new List1000  folder.
            /// </summary>
            public List1000AppFolder(RepoGenBaseFolder parentFolder) :
                    base("List1000", "/list[@controlid='1000']", parentFolder, 30000, null, true, "6c27dd37-0aef-4318-8460-09f7f702922b", "")
            {
                _salesInfo = new RepoItemInfo(this, "Sales", "listitem[@text=$AREA]", 30000, null, "70e74104-224d-46c7-aa29-024367375245");
                _marketingInfo = new RepoItemInfo(this, "Marketing", "listitem[@text='Marketing']", 30000, null, "c048c07e-5a05-4d8f-b676-26589ad219c8");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6c27dd37-0aef-4318-8460-09f7f702922b")]
            public virtual Ranorex.List Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.List>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("6c27dd37-0aef-4318-8460-09f7f702922b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Sales item.
            /// </summary>
            [RepositoryItem("70e74104-224d-46c7-aa29-024367375245")]
            public virtual Ranorex.ListItem Sales
            {
                get
                {
                    return _salesInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Sales item info.
            /// </summary>
            [RepositoryItemInfo("70e74104-224d-46c7-aa29-024367375245")]
            public virtual RepoItemInfo SalesInfo
            {
                get
                {
                    return _salesInfo;
                }
            }

            /// <summary>
            /// The Marketing item.
            /// </summary>
            [RepositoryItem("c048c07e-5a05-4d8f-b676-26589ad219c8")]
            public virtual Ranorex.ListItem Marketing
            {
                get
                {
                    return _marketingInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Marketing item info.
            /// </summary>
            [RepositoryItemInfo("c048c07e-5a05-4d8f-b676-26589ad219c8")]
            public virtual RepoItemInfo MarketingInfo
            {
                get
                {
                    return _marketingInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
