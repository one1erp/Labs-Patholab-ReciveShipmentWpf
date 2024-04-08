using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Documents;
using LSExtensionWindowLib;
using LSSERVICEPROVIDERLib;
using Patholab_Common;
using System.Runtime.InteropServices;
using System.Windows.Forms;
 
using Patholab_DAL_V1;
using Patholab_XmlService;

using System.Diagnostics;


namespace ReciveShipmentWpf
{


    [ComVisible(true)]
    [ProgId("ReciveShipment.ReciveShipmentWpfCls")]
    public partial class ReciveShipmentWpfCls : UserControl, IExtensionWindow
    {
        #region Private fields
        private INautilusProcessXML xmlProcessor;
        private INautilusUser _ntlsUser;
        private IExtensionWindowSite2 _ntlsSite;
        private INautilusServiceProvider sp;
        private INautilusDBConnection _ntlsCon;
   
       
        public bool DEBUG;
        private List<U_CONTAINER> shipmentslist; 
        #endregion

        #region Ctor

        public ReciveShipmentWpfCls()
        {
            InitializeComponent();
            BackColor = Color.FromName("Control");

        }

        #endregion


     

        public bool CloseQuery()
        {
          

            return true;
        }

        public void Internationalise()
        {
        }

        public void SetSite(object site)
        {
            _ntlsSite = (IExtensionWindowSite2)site;
            _ntlsSite.SetWindowInternalName("");
            _ntlsSite.SetWindowRegistryName("");
            _ntlsSite.SetWindowTitle("קבלת משלוחים v2");
        }

   
     

        public void PreDisplay()
        {

            xmlProcessor = Utils.GetXmlProcessor(sp);

            _ntlsUser = Utils.GetNautilusUser(sp);

            WpfShipmentCtl w = new WpfShipmentCtl(sp,xmlProcessor, _ntlsCon, _ntlsSite, _ntlsUser);
          elementHost1.Child = w;
            w.InitializeData();
        }

        public WindowButtonsType GetButtons()
        {
            return LSExtensionWindowLib.WindowButtonsType.windowButtonsNone;
        }

        public bool SaveData()
        {
            return false;
        }

        public void SetServiceProvider(object serviceProvider)
        {
            sp = serviceProvider as NautilusServiceProvider;
            _ntlsCon = Utils.GetNtlsCon(sp);

        }

        public void SetParameters(string parameters)
        {

        }

        public void Setup()
        {

        }

        public WindowRefreshType DataChange()
        {
            return LSExtensionWindowLib.WindowRefreshType.windowRefreshNone;
        }

        public WindowRefreshType ViewRefresh()
        {
            return LSExtensionWindowLib.WindowRefreshType.windowRefreshNone;
        }

        public void refresh()
        {
        }

        public void SaveSettings(int hKey)
        {
        }

        public void RestoreSettings(int hKey)
        {
        }

        public void Close()
        {

        }
    
        
   

        

      

        
       
        
       

      
    }
    

 

}


   
