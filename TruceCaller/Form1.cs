using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System.IO;
using OpenQA.Selenium.Support.UI;
using System.Drawing.Imaging;
using OpenQA.Selenium.Interactions;

namespace TruceCaller
{
    public partial class frm_TrueCaller : Form
    {
        static string filename;
        static int size = 0;
        static string[] numbers = new string[size];
        public frm_TrueCaller()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            check();
        }
        void open()
        {
            //////////////////FileDialog////////////////////////////////////
            if (oFD_Select.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(oFD_Select.FileName);
                filename = oFD_Select.FileName;
                ///////////////////Excel/////////////////////////////////////

                Excel.Application xlApp = new Excel.Application(); ;
                Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(@filename, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Excel.Worksheet xlWorkSheet;
                Excel.Range range;
                string str;
                int rCnt;
                int cCnt;
                int rw = 0;
                int cl = 0;



                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                range = xlWorkSheet.UsedRange;
                rw = range.Rows.Count;
                cl = range.Columns.Count;
                size = rw;
                numbers = new string[size];


                for (rCnt = 1; rCnt <= rw; rCnt++)
                {
                    for (cCnt = 1; cCnt <= cl; cCnt++)
                    {
                        str = (range.Cells[rCnt, cCnt] as Excel.Range).Value2.ToString();
                        if (rCnt > 1)
                        {
                            numbers[rCnt - 1] = "+" + str;
                            // MessageBox.Show(numbers[rCnt - 1]);
                        }


                    }
                }

                xlWorkBook.Close(true, null, null);
                xlApp.Quit();
                ////////////Excel/////////////////////////////////////////////////////
                MessageBox.Show("Numbers have been listed, Click on Ok to Start Crawling");
                
                foreach (var x in numbers)
                {
                    crawl(x);
                }
            }
        }
        void check()
        {
            int ch = 3;
            while (ch == 3)
            {
                ch = look();
                lbl_Check.Text = "";
                if (ch == 0)
                {
                    lbl_Check.Text = "Signed Out";
                    btn_Sign_OUT.Enabled = false;
                    btn_Sign_IN.Enabled = true;
                }
                else if (ch == 1)
                {
                    lbl_Check.Text = "Signed In";
                    btn_Sign_IN.Enabled = false;
                    btn_Sign_OUT.Enabled = true;
                }
                else
                {
                    lbl_Check.Text = "Checking...";
                    btn_Sign_IN.Enabled = false;
                    btn_Sign_OUT.Enabled = false;
                }
            }
        }
        int look()
        {
            var driverService = PhantomJSDriverService.CreateDefaultService(Environment.CurrentDirectory);
            driverService.HideCommandPromptWindow = true;
            IWebDriver driver = new PhantomJSDriver(driverService);
            driver.Navigate().GoToUrl("https://www.truecaller.com/");
            try
            {
                if (driver.PageSource.Contains("Sign out"))
                {
                    return 1;
                }
                else if (driver.PageSource.Contains("Sign in"))
                {
                
                    return 0;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Can't find_out");
                MessageBox.Show(e.Message);
            }
            finally
            {
                driver.Close();
                driver.Quit();
            }
            return 3;
        }
        void sign_out()
        {

            var driverService = PhantomJSDriverService.CreateDefaultService(Environment.CurrentDirectory);
            driverService.HideCommandPromptWindow = true;
            IWebDriver driver = new PhantomJSDriver(driverService);
            driver.Navigate().GoToUrl("https://www.truecaller.com/");
            try
            {
                var div = driver.FindElement(By.TagName("div")).FindElement(By.XPath("//*[contains(text(), 'Sign out')]"));
                string js = "arguments[0].click();";

                ((IJavaScriptExecutor)driver).ExecuteScript(js, div);

                Thread.Sleep(10);


                MessageBox.Show("Signed Out Successfully");
                lbl_Check.Text = "Signed Out";
                btn_Sign_IN.Enabled = true;
                btn_Sign_OUT.Enabled =false;
            }
            catch(Exception e)
            {
                MessageBox.Show("You Need to Signed in, In order to get Signed Out");
                MessageBox.Show(e.Message);
            }
            finally
            {
                driver.Close();
                driver.Quit();
            }
        }

        void sign_in()
        {
            var driverService = PhantomJSDriverService.CreateDefaultService(Environment.CurrentDirectory);
            driverService.HideCommandPromptWindow = true;
            IWebDriver driver = new PhantomJSDriver(driverService);
            driver.Navigate().GoToUrl("https://www.truecaller.com/");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement user, password;
                try
                {
                var div = driver.FindElement(By.TagName("div")).FindElement(By.XPath("//*[contains(text(), 'Sign in')]"));
                string js = "arguments[0].click();";
                ((IJavaScriptExecutor)driver).ExecuteScript(js, div);
                wait.Until(ExpectedConditions.ElementExists(By.ClassName("sign-in-dialog-provider")));
                driver.FindElement(By.ClassName("sign-in-dialog-provider")).Click();
                wait.Until(ExpectedConditions.ElementExists(By.Id("Email")));
                user = driver.FindElement(By.Id("Email"));
                    user.Clear();
                    user.SendKeys(txtBox_User.Text);
                    driver.FindElement(By.Id("next")).Click();
                wait.Until(ExpectedConditions.ElementExists(By.Name("Passwd"))); 
                    password = driver.FindElement(By.Name("Passwd"));
                    password.Clear();
                    password.SendKeys(txtBox_Pass.Text);
                    driver.FindElement(By.Id("signIn")).Click();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


                MessageBox.Show("Signed In Successfully");
                lbl_Check.Text = "Signed In";
                btn_Sign_IN.Enabled = false;
                btn_Sign_OUT.Enabled = true;
            }
                catch (Exception e)
                {
                    MessageBox.Show("Try Again, Can't Sign In");
                    MessageBox.Show(e.Message);
                }
            finally
            {
                driver.Close();
                driver.Quit();
            }
            }

        void crawl(string number)
        {  
                 var driverService = PhantomJSDriverService.CreateDefaultService(Environment.CurrentDirectory);
        
           
             driverService.HideCommandPromptWindow = true;
           
            IWebDriver driver = new PhantomJSDriver(driverService);
            driver.Navigate().GoToUrl("https://www.truecaller.com/");
          
            try
            {
             //       ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"E:\Haider\Haider\Beautiful Soup\img1.jpg", ScreenshotImageFormat.Jpeg);
                        var set = driver.FindElement(By.ClassName("searchbar__query"));
                     set.SendKeys("+"+number);
                var button = driver.FindElement(By.ClassName("searchbar__submit"));
                string js = "arguments[0].click();";

                ((IJavaScriptExecutor)driver).ExecuteScript(js, button);

                Thread.Sleep(10);


                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
                string name="";
                string  other_details="";
                Loboloba.Text = "";
                foreach (var element in driver.FindElements(By.CssSelector("div.profile-name")))
                {
                Loboloba.Text+= name= element.Text+Environment.NewLine;
                }
                foreach (var element in driver.FindElements(By.CssSelector("div.profile-details-text")))
                {
                    Loboloba.Text += other_details = element.Text+Environment.NewLine;
                }
                   
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            finally
            {
              
                driver.Close();
                driver.Quit();
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(sign_in);
            th.Start();
            
        }

        private void btn_Crawl_Click(object sender, EventArgs e)
        {
            crawl(txtBox_Number.Text.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            open();
        }

        private void btn_UnA_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(sign_out);
            th.Start();
            
        }

        private void lbl_Check_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_Number_CursorChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
