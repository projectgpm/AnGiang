using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Globalization;
using System.Threading;
using QLCafe.Properties;
using QLCafe.DAO;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using Microsoft.VisualBasic.ApplicationServices;

namespace QLCafe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //bool result;
            //var mutex = new System.Threading.Mutex(true, "QLCafe", out result);

            //if (!result)
            //{
            //    XtraMessageBox.Show("Ứng dụng đang hoạt động.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Application.Exit();
            //    return;
            //}

            //CultureInfo culture = CultureInfo.CreateSpecificCulture("vi-VN");
            //Thread.CurrentThread.CurrentUICulture = culture;
            BonusSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            SkinManager.EnableFormSkins();
            DevExpress.Utils.Paint.XPaint.ForceGDIPlusPaint();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // UserLookAndFeel.Default.SetSkinStyle(Settings.Default.SkinName);
            Localizer.Active = new MyLocalizer();
            if (DataProvider.Instance.CheckConnection())
            {
                try
                {

                    if (DataProvider.Instance.KiemDuLieuTonTaiTrongCSDL("CF_ChiNhanh") <= 0)
                    {

                        if (XtraMessageBox.Show("Bạn muốn khởi tạo cơ sở dữ liệu nào:", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SplashScreenManager.ShowForm(typeof(WaitForm2));
                            DataProvider.Instance.ExecuteQuery("rp_CapNhatDataBase @KiemTra", new object[] { 1 });
                            SplashScreenManager.CloseForm();
                        }
                        else
                        {
                            SplashScreenManager.ShowForm(typeof(WaitForm2));
                            DataProvider.Instance.ExecuteQuery("rp_CapNhatDataBase @KiemTra", new object[] { 0 });
                            SplashScreenManager.CloseForm();
                        }
                    }


                    App myApp = new App();
                    myApp.Run(args);
                   // Application.Run(new XtraForm1());
                }
                catch (Exception ex) { XtraMessageBox.Show("Lỗi hệ thống:\n Mã lỗi:" + ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
        }

        public class MyLocalizer : Localizer
        {
            public override string GetLocalizedString(StringId id)
            {
                switch (id)
                {
                    case StringId.XtraMessageBoxYesButtonText:
                        return "1.Có dữ liệu mẫu";
                    case StringId.XtraMessageBoxNoButtonText:
                        return "2.Không có dữ liệu mẫu";
                    default:
                        return base.GetLocalizedString(id);
                }
            }
        }

        /// <summary>
        /// We inherit from the VB.NET WindowsFormApplicationBase class, which has the 
        /// single-instance functionality.
        /// </summary>
        class App : WindowsFormsApplicationBase
        {
            public App()
            {
                // Make this a single-instance application
                this.IsSingleInstance = true;
                this.EnableVisualStyles = true;

                // There are some other things available in the VB application model, for
                // instance the shutdown style:
                this.ShutdownStyle = Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses;

                // Add StartupNextInstance handler
                this.StartupNextInstance += new StartupNextInstanceEventHandler(this.SIApp_StartupNextInstance);
            }

            /// <summary>
            /// We are responsible for creating the application's main form in this override.
            /// </summary>
            protected override void OnCreateMainForm()
            {
                // Create an instance of the main form and set it in the application; 
                // but don't try to run it.
                this.MainForm = new frmDangNhap();

                // We want to pass along the command-line arguments to this first instance

                // Allocate room in our string array
                ((frmDangNhap)this.MainForm).Args = new string[this.CommandLineArgs.Count];

                // And copy the arguments over to our form
                this.CommandLineArgs.CopyTo(((frmDangNhap)this.MainForm).Args, 0);
            }

            /// <summary>
            /// This is called for additional instances. The application model will call this 
            /// function, and terminate the additional instance when this returns.
            /// </summary>
            /// <param name="eventArgs"></param>
            protected void SIApp_StartupNextInstance(object sender,
                StartupNextInstanceEventArgs eventArgs)
            {
                // Copy the arguments to a string array
                string[] args = new string[eventArgs.CommandLine.Count];
                eventArgs.CommandLine.CopyTo(args, 0);

                // Create an argument array for the Invoke method
                object[] parameters = new object[2];
                parameters[0] = this.MainForm;
                parameters[1] = args;

                // Need to use invoke to b/c this is being called from another thread.
                this.MainForm.Invoke(new frmDangNhap.ProcessParametersDelegate(
                    ((frmDangNhap)this.MainForm).ProcessParameters),
                    parameters);
            }
        }
    }
}
