﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      Este código lo generó el generador de pruebas automatizadas de IU.
//      Versión: 16.0.0.0
//
//      Los cambios realizados en este archivo pueden provocar un comportamiento incorrecto y se perderán si
//      se vuelve a generar el código.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITest_Gestion_Pedidos
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Gestion Pedidos
        /// </summary>
        public void RecordedMethod()
        {
            #region Variable Declarations
            WinEdit uIEditEdit = this.UIViewLogWindow.UIEntertextWindow.UIEditEdit;
            WinClient uITxt2Client = this.UIViewLogWindow.UITxt2Window.UITxt2Client;
            WinEdit uIEditEdit1 = this.UIViewLogWindow.UIEntertextWindow1.UIEditEdit;
            WinClient uIIniciarSesionClient = this.UIViewLogWindow.UIBtnIniciarSesionWindow.UIIniciarSesionClient;
            WinButton uIOKButton = this.UIOKWindow.UIOKButton;
            WinText uIGestiondePedidosText = this.UIViewPrincipalWindow.UIGestiondePedidosWindow.UIGestiondePedidosText;
            WinClient uIBtnBuscarClient = this.UIViewPrincipalWindow.UIBtnBuscarWindow.UIBtnBuscarClient;
            WinClient uIESTADOClient = this.UIViewPrincipalWindow.UIItemWindow.UIESTADOClient;
            WinClient uIESTADOClient1 = this.UIViewPrincipalWindow.UIChkSeleccionarWindow.UIESTADOClient;
            WinCell uINullCell = this.UIViewPrincipalWindow.UIDgvPedidosWindow.UIDataGridViewTable.UIRow1Row.UINullCell;
            WinText uIDesaprobarText = this.UIViewPrincipalWindow.UIDesaprobarWindow.UIDesaprobarText;
            WinButton uICloseButton = this.UIViewPrincipalWindow.UIViewPrincipalTitleBar.UICloseButton;
            #endregion

            // Iniciar '%USERPROFILE%\Downloads\DDD (1)\DDD\UI.Desktop\bin\Debug\UI.Desktop.exe'
            ApplicationUnderTest uIViewLogWindow = ApplicationUnderTest.Launch(this.RecordedMethodParams.UIViewLogWindowExePath, this.RecordedMethodParams.UIViewLogWindowAlternateExePath);

            // Escribir 'Admin' en cuadro de texto 'edit'
            uIEditEdit.Text = this.RecordedMethodParams.UIEditEditText;

            // Clic 'txt2' cliente
            Mouse.Click(uITxt2Client, new Point(72, 6));

            // Escribir '123qweu0' en cuadro de texto 'edit'
            uIEditEdit1.Text = this.RecordedMethodParams.UIEditEditText1;

            // Clic 'Iniciar Sesion' cliente
            Mouse.Click(uIIniciarSesionClient, new Point(80, 28));

            // Clic 'OK' botón
            Mouse.Click(uIOKButton, new Point(40, 10));

            // Clic 'Gestion de Pedidos' etiqueta
            Mouse.Click(uIGestiondePedidosText, new Point(43, 5));

            // Clic 'btnBuscar' cliente
            Mouse.Click(uIBtnBuscarClient, new Point(15, 8));

            // Clic 'ESTADO' cliente
            Mouse.Click(uIESTADOClient, new Point(11, 6));

            // Clic 'ESTADO' cliente
            Mouse.Click(uIESTADOClient1, new Point(5, 16));

            // Clic '(null)' celda
            Mouse.Click(uINullCell, new Point(38, 14));

            // Clic 'Desaprobar' etiqueta
            Mouse.Click(uIDesaprobarText, new Point(49, 14));

            // Clic 'OK' botón
            Mouse.Click(uIOKButton, new Point(27, 9));

            // Clic 'Close' botón
            Mouse.Click(uICloseButton, new Point(13, 25));
        }
        
        #region Properties
        public virtual RecordedMethodParams RecordedMethodParams
        {
            get
            {
                if ((this.mRecordedMethodParams == null))
                {
                    this.mRecordedMethodParams = new RecordedMethodParams();
                }
                return this.mRecordedMethodParams;
            }
        }
        
        public UIViewLogWindow UIViewLogWindow
        {
            get
            {
                if ((this.mUIViewLogWindow == null))
                {
                    this.mUIViewLogWindow = new UIViewLogWindow();
                }
                return this.mUIViewLogWindow;
            }
        }
        
        public UIOKWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow();
                }
                return this.mUIOKWindow;
            }
        }
        
        public UIViewPrincipalWindow UIViewPrincipalWindow
        {
            get
            {
                if ((this.mUIViewPrincipalWindow == null))
                {
                    this.mUIViewPrincipalWindow = new UIViewPrincipalWindow();
                }
                return this.mUIViewPrincipalWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethodParams mRecordedMethodParams;
        
        private UIViewLogWindow mUIViewLogWindow;
        
        private UIOKWindow mUIOKWindow;
        
        private UIViewPrincipalWindow mUIViewPrincipalWindow;
        #endregion
    }
    
    /// <summary>
    /// Parámetros que se van a pasar a 'RecordedMethod'
    /// </summary>
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class RecordedMethodParams
    {
        
        #region Fields
        /// <summary>
        /// Iniciar '%USERPROFILE%\Downloads\DDD (1)\DDD\UI.Desktop\bin\Debug\UI.Desktop.exe'
        /// </summary>
        public string UIViewLogWindowExePath = "C:\\Users\\USUARIO\\Downloads\\DDD (1)\\DDD\\UI.Desktop\\bin\\Debug\\UI.Desktop.exe";
        
        /// <summary>
        /// Iniciar '%USERPROFILE%\Downloads\DDD (1)\DDD\UI.Desktop\bin\Debug\UI.Desktop.exe'
        /// </summary>
        public string UIViewLogWindowAlternateExePath = "%USERPROFILE%\\Downloads\\DDD (1)\\DDD\\UI.Desktop\\bin\\Debug\\UI.Desktop.exe";
        
        /// <summary>
        /// Escribir 'Admin' en cuadro de texto 'edit'
        /// </summary>
        public string UIEditEditText = "Admin";
        
        /// <summary>
        /// Escribir '123qweu0' en cuadro de texto 'edit'
        /// </summary>
        public string UIEditEditText1 = "123qweu0";
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIViewLogWindow : WinWindow
    {
        
        public UIViewLogWindow()
        {
            #region Criterio de búsqueda
            this.SearchProperties[WinWindow.PropertyNames.Name] = "ViewLog";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("ViewLog");
            #endregion
        }
        
        #region Properties
        public UIEntertextWindow UIEntertextWindow
        {
            get
            {
                if ((this.mUIEntertextWindow == null))
                {
                    this.mUIEntertextWindow = new UIEntertextWindow(this);
                }
                return this.mUIEntertextWindow;
            }
        }
        
        public UITxt2Window UITxt2Window
        {
            get
            {
                if ((this.mUITxt2Window == null))
                {
                    this.mUITxt2Window = new UITxt2Window(this);
                }
                return this.mUITxt2Window;
            }
        }
        
        public UIEntertextWindow1 UIEntertextWindow1
        {
            get
            {
                if ((this.mUIEntertextWindow1 == null))
                {
                    this.mUIEntertextWindow1 = new UIEntertextWindow1(this);
                }
                return this.mUIEntertextWindow1;
            }
        }
        
        public UIBtnIniciarSesionWindow UIBtnIniciarSesionWindow
        {
            get
            {
                if ((this.mUIBtnIniciarSesionWindow == null))
                {
                    this.mUIBtnIniciarSesionWindow = new UIBtnIniciarSesionWindow(this);
                }
                return this.mUIBtnIniciarSesionWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIEntertextWindow mUIEntertextWindow;
        
        private UITxt2Window mUITxt2Window;
        
        private UIEntertextWindow1 mUIEntertextWindow1;
        
        private UIBtnIniciarSesionWindow mUIBtnIniciarSesionWindow;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIEntertextWindow : WinWindow
    {
        
        public UIEntertextWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Criterio de búsqueda
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "edit";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "2";
            this.WindowTitles.Add("ViewLog");
            #endregion
        }
        
        #region Properties
        public WinEdit UIEditEdit
        {
            get
            {
                if ((this.mUIEditEdit == null))
                {
                    this.mUIEditEdit = new WinEdit(this);
                    #region Criterio de búsqueda
                    this.mUIEditEdit.WindowTitles.Add("ViewLog");
                    #endregion
                }
                return this.mUIEditEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIEditEdit;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UITxt2Window : WinWindow
    {
        
        public UITxt2Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Criterio de búsqueda
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txt2";
            this.WindowTitles.Add("ViewLog");
            #endregion
        }
        
        #region Properties
        public WinClient UITxt2Client
        {
            get
            {
                if ((this.mUITxt2Client == null))
                {
                    this.mUITxt2Client = new WinClient(this);
                    #region Criterio de búsqueda
                    this.mUITxt2Client.WindowTitles.Add("ViewLog");
                    #endregion
                }
                return this.mUITxt2Client;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUITxt2Client;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIEntertextWindow1 : WinWindow
    {
        
        public UIEntertextWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Criterio de búsqueda
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "edit";
            this.WindowTitles.Add("ViewLog");
            #endregion
        }
        
        #region Properties
        public WinEdit UIEditEdit
        {
            get
            {
                if ((this.mUIEditEdit == null))
                {
                    this.mUIEditEdit = new WinEdit(this);
                    #region Criterio de búsqueda
                    this.mUIEditEdit.WindowTitles.Add("ViewLog");
                    #endregion
                }
                return this.mUIEditEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIEditEdit;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIBtnIniciarSesionWindow : WinWindow
    {
        
        public UIBtnIniciarSesionWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Criterio de búsqueda
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnIniciarSesion";
            this.WindowTitles.Add("ViewLog");
            #endregion
        }
        
        #region Properties
        public WinClient UIIniciarSesionClient
        {
            get
            {
                if ((this.mUIIniciarSesionClient == null))
                {
                    this.mUIIniciarSesionClient = new WinClient(this);
                    #region Criterio de búsqueda
                    this.mUIIniciarSesionClient.SearchProperties[WinControl.PropertyNames.Name] = "Iniciar Sesion";
                    this.mUIIniciarSesionClient.WindowTitles.Add("ViewLog");
                    #endregion
                }
                return this.mUIIniciarSesionClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIIniciarSesionClient;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIOKWindow : WinWindow
    {
        
        public UIOKWindow()
        {
            #region Criterio de búsqueda
            this.SearchProperties[WinWindow.PropertyNames.Name] = "OK";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Button";
            this.WindowTitles.Add("OK");
            #endregion
        }
        
        #region Properties
        public WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WinButton(this);
                    #region Criterio de búsqueda
                    this.mUIOKButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                    this.mUIOKButton.WindowTitles.Add("OK");
                    #endregion
                }
                return this.mUIOKButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOKButton;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIViewPrincipalWindow : WinWindow
    {
        
        public UIViewPrincipalWindow()
        {
            #region Criterio de búsqueda
            this.SearchProperties[WinWindow.PropertyNames.Name] = "ViewPrincipal";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("ViewPrincipal");
            #endregion
        }
        
        #region Properties
        public UIGestiondePedidosWindow UIGestiondePedidosWindow
        {
            get
            {
                if ((this.mUIGestiondePedidosWindow == null))
                {
                    this.mUIGestiondePedidosWindow = new UIGestiondePedidosWindow(this);
                }
                return this.mUIGestiondePedidosWindow;
            }
        }
        
        public UIBtnBuscarWindow UIBtnBuscarWindow
        {
            get
            {
                if ((this.mUIBtnBuscarWindow == null))
                {
                    this.mUIBtnBuscarWindow = new UIBtnBuscarWindow(this);
                }
                return this.mUIBtnBuscarWindow;
            }
        }
        
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIChkSeleccionarWindow UIChkSeleccionarWindow
        {
            get
            {
                if ((this.mUIChkSeleccionarWindow == null))
                {
                    this.mUIChkSeleccionarWindow = new UIChkSeleccionarWindow(this);
                }
                return this.mUIChkSeleccionarWindow;
            }
        }
        
        public UIDgvPedidosWindow UIDgvPedidosWindow
        {
            get
            {
                if ((this.mUIDgvPedidosWindow == null))
                {
                    this.mUIDgvPedidosWindow = new UIDgvPedidosWindow(this);
                }
                return this.mUIDgvPedidosWindow;
            }
        }
        
        public UIDesaprobarWindow UIDesaprobarWindow
        {
            get
            {
                if ((this.mUIDesaprobarWindow == null))
                {
                    this.mUIDesaprobarWindow = new UIDesaprobarWindow(this);
                }
                return this.mUIDesaprobarWindow;
            }
        }
        
        public UIViewPrincipalTitleBar UIViewPrincipalTitleBar
        {
            get
            {
                if ((this.mUIViewPrincipalTitleBar == null))
                {
                    this.mUIViewPrincipalTitleBar = new UIViewPrincipalTitleBar(this);
                }
                return this.mUIViewPrincipalTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UIGestiondePedidosWindow mUIGestiondePedidosWindow;
        
        private UIBtnBuscarWindow mUIBtnBuscarWindow;
        
        private UIItemWindow mUIItemWindow;
        
        private UIChkSeleccionarWindow mUIChkSeleccionarWindow;
        
        private UIDgvPedidosWindow mUIDgvPedidosWindow;
        
        private UIDesaprobarWindow mUIDesaprobarWindow;
        
        private UIViewPrincipalTitleBar mUIViewPrincipalTitleBar;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIGestiondePedidosWindow : WinWindow
    {
        
        public UIGestiondePedidosWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Criterio de búsqueda
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "Label";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "3";
            this.WindowTitles.Add("ViewPrincipal");
            #endregion
        }
        
        #region Properties
        public WinText UIGestiondePedidosText
        {
            get
            {
                if ((this.mUIGestiondePedidosText == null))
                {
                    this.mUIGestiondePedidosText = new WinText(this);
                    #region Criterio de búsqueda
                    this.mUIGestiondePedidosText.SearchProperties[WinText.PropertyNames.Name] = "Gestion de Pedidos";
                    this.mUIGestiondePedidosText.WindowTitles.Add("ViewPrincipal");
                    #endregion
                }
                return this.mUIGestiondePedidosText;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIGestiondePedidosText;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIBtnBuscarWindow : WinWindow
    {
        
        public UIBtnBuscarWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Criterio de búsqueda
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnBuscar";
            this.WindowTitles.Add("ViewPrincipal");
            #endregion
        }
        
        #region Properties
        public WinClient UIBtnBuscarClient
        {
            get
            {
                if ((this.mUIBtnBuscarClient == null))
                {
                    this.mUIBtnBuscarClient = new WinClient(this);
                    #region Criterio de búsqueda
                    this.mUIBtnBuscarClient.WindowTitles.Add("ViewPrincipal");
                    #endregion
                }
                return this.mUIBtnBuscarClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIBtnBuscarClient;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Criterio de búsqueda
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "4";
            this.WindowTitles.Add("ViewPrincipal");
            #endregion
        }
        
        #region Properties
        public WinClient UIESTADOClient
        {
            get
            {
                if ((this.mUIESTADOClient == null))
                {
                    this.mUIESTADOClient = new WinClient(this);
                    #region Criterio de búsqueda
                    this.mUIESTADOClient.WindowTitles.Add("ViewPrincipal");
                    #endregion
                }
                return this.mUIESTADOClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIESTADOClient;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIChkSeleccionarWindow : WinWindow
    {
        
        public UIChkSeleccionarWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Criterio de búsqueda
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "chkSeleccionar";
            this.WindowTitles.Add("ViewPrincipal");
            #endregion
        }
        
        #region Properties
        public WinClient UIESTADOClient
        {
            get
            {
                if ((this.mUIESTADOClient == null))
                {
                    this.mUIESTADOClient = new WinClient(this);
                    #region Criterio de búsqueda
                    this.mUIESTADOClient.SearchProperties[WinControl.PropertyNames.Name] = "ESTADO";
                    this.mUIESTADOClient.WindowTitles.Add("ViewPrincipal");
                    #endregion
                }
                return this.mUIESTADOClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIESTADOClient;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIDgvPedidosWindow : WinWindow
    {
        
        public UIDgvPedidosWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Criterio de búsqueda
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "dgvPedidos";
            this.WindowTitles.Add("ViewPrincipal");
            #endregion
        }
        
        #region Properties
        public UIDataGridViewTable UIDataGridViewTable
        {
            get
            {
                if ((this.mUIDataGridViewTable == null))
                {
                    this.mUIDataGridViewTable = new UIDataGridViewTable(this);
                }
                return this.mUIDataGridViewTable;
            }
        }
        #endregion
        
        #region Fields
        private UIDataGridViewTable mUIDataGridViewTable;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIDataGridViewTable : WinTable
    {
        
        public UIDataGridViewTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Criterio de búsqueda
            this.SearchProperties[WinTable.PropertyNames.Name] = "DataGridView";
            this.WindowTitles.Add("ViewPrincipal");
            #endregion
        }
        
        #region Properties
        public UIRow1Row UIRow1Row
        {
            get
            {
                if ((this.mUIRow1Row == null))
                {
                    this.mUIRow1Row = new UIRow1Row(this);
                }
                return this.mUIRow1Row;
            }
        }
        #endregion
        
        #region Fields
        private UIRow1Row mUIRow1Row;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIRow1Row : WinRow
    {
        
        public UIRow1Row(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Criterio de búsqueda
            this.SearchProperties[WinRow.PropertyNames.Value] = "(null);14;Angelica;20;11/9/2021 2:32:35 PM";
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("ViewPrincipal");
            #endregion
        }
        
        #region Properties
        public WinCell UINullCell
        {
            get
            {
                if ((this.mUINullCell == null))
                {
                    this.mUINullCell = new WinCell(this);
                    #region Criterio de búsqueda
                    this.mUINullCell.SearchProperties[WinCell.PropertyNames.Value] = "(null)";
                    this.mUINullCell.WindowTitles.Add("ViewPrincipal");
                    #endregion
                }
                return this.mUINullCell;
            }
        }
        #endregion
        
        #region Fields
        private WinCell mUINullCell;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIDesaprobarWindow : WinWindow
    {
        
        public UIDesaprobarWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Criterio de búsqueda
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "Label";
            this.WindowTitles.Add("ViewPrincipal");
            #endregion
        }
        
        #region Properties
        public WinText UIDesaprobarText
        {
            get
            {
                if ((this.mUIDesaprobarText == null))
                {
                    this.mUIDesaprobarText = new WinText(this);
                    #region Criterio de búsqueda
                    this.mUIDesaprobarText.SearchProperties[WinText.PropertyNames.Name] = "Desaprobar";
                    this.mUIDesaprobarText.WindowTitles.Add("ViewPrincipal");
                    #endregion
                }
                return this.mUIDesaprobarText;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIDesaprobarText;
        #endregion
    }
    
    [GeneratedCode("Generador de pruebas de UI codificadas", "16.0.31306.167")]
    public class UIViewPrincipalTitleBar : WinTitleBar
    {
        
        public UIViewPrincipalTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Criterio de búsqueda
            this.WindowTitles.Add("ViewPrincipal");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Criterio de búsqueda
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("ViewPrincipal");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
}