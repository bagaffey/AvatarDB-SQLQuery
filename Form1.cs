/*
 * Cache XML Service (Netsmart Avatar)
 * 
 * DESCRIPTION:
 * This windows form application uses the WSAPI.RADplus.XML.XMLservice which is an Avatar web service that allows you to submit 
 * a SQL query to the Caché database. The SQL syntax complies with Caché SQL which is the InterSystems extension of SQL-92. This is a 
 * useful tool for testing SQL queries against your Avatar Caché database. This tool is particularly helpful during widget, reports, or 
 * any other reporting development so that you can get results from your widget instantly.
 * The result is returned in XML format; however, you can switch how that data is displayed i.e. you can view the returned XML or 
 * view the data within a datagrid (which is easier on the eyes). The XML is useful when you're debugging your query to see 
 * where something may have gone wrong as the full error message from the SOAP web service would be displayed there.
 * NOTE: This has only been tested with InterSystems Caché 2010.2
 * 
 * AUTHOR:
 * Barry Gaffey
 * 
 * DATE CREATED:
 * July 22nd, 2013
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace CacheXMLService
{
    public partial class MainForm : Form
    {
        String newline = System.Environment.NewLine;
        String runtimeMode = "0";
        String sqlQuery = "";
        String systemCode = "SYS";
        String userName = "USER";
        String password = "PASS1";
        String XMLdata2export = "";

        /**
         * <summary>This initializes the main WinForm of this program.</summary>
         */
        public MainForm()
        {
            InitializeComponent();
        }

        /**
         * <summary>Exits the application.</summary>
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * <summary> This method will construct a SOAP message and send it to the web service. </summary>
         * <remarks> This web service does not seem to be enabled. It needs to be enabled before using otherwise,
         * this program will encounter an InvalidOperationException</remarks>
         * <param name="loginInfo">Web service LoginInfo class that contains the logon credentials necessary to file the web service.</param>
         * <param name="sql">The SQL query text to be interpreted by the Cache database.</param>
         * <param name="runtimeMode">This property will set the SQL runtime mode for the query to be executed. There are 3 modes to choose from 0,1,2.
         * 0 for LOGICAL mode also the DEFAULT. 1 for ODBC mode. 2 for DISPLAY mode.</param>
         * <returns>The web service response is returned by this method because this is the call that is made to the web service. This response will contain
         * the sql query results if no errors were encountered otherwise read the message part of the response to determine what error was detected.</returns>
         */
        private XMLService.XMLResponse submitSQL(XMLService.LoginInfo loginInfo, String sql, String runtimeMode)
        {
            try
            {
                var XMLServiceInstance = new XMLService.XMLService();
                return XMLServiceInstance.XMLResultSet(loginInfo, sql, runtimeMode);
            }
            catch (InvalidOperationException e)
            {
                XMLService.XMLResponse Err = new XMLService.XMLResponse();
                Err.resultCode = "-1";
                Err.resultMessage = e.Message + newline + "A fatal exception was encountered, this is known to occur when the XMLService web service is not"
                    + " enabled in your system. Contact your Netsmart Representative for further information.";
                return Err;
            }
        }

        /**
         * <summary>When the submit button is clicked, this method is executed. This will get the wheels turning, construct the SOAP message and send it
         * to the referenced Avatar web service.</summary>
         */
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /* Collect parameters for the Web Service. */
            runtimeMode = ascertainRuntimeMode(); // runtime mode
            sqlQuery = SQLtextbox.Text; // The SQL query
            
            /* builds and sends SOAP message. */
            XMLService.XMLResponse response = submitSQL(buildLoginInfo(), sqlQuery, runtimeMode);
            
            /* Display response - this will clear the previous response in the textbox. */
            ResponseBox.Text = "Result Code: " + response.resultCode + newline + "Result Message: " + response.resultMessage + newline;
            ResponseBox.Text += response.XMLResponse1 + newline;
            XMLdata2export = response.XMLResponse1 + newline;

            /* A resultCode of 1 indicates that there were no errors returned from the database. */
            if (response.resultCode == "1")
            {
                displayXMLTextFriendly(XMLdata2export);
            }
            else
                MessageBox.Show(response.resultMessage);
        }

        /**
         * <summary>This method is responsible for displaying the returned data within a datagrid. The returned data is in XML.</summary>
         * <param name="XMLtext">This is the xml text that is returned from the database's web service. This XML text contains the results
         * of the query.</param>
         * */
        private void displayXMLTextFriendly(string XMLtext)
        {

            try
            {
                XmlReader xmlFile;
                xmlFile = XmlReader.Create(new StringReader(XMLtext));
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();
                ds2.Tables.Add();
                ds.ReadXml(xmlFile);

                int nub = 0;
                foreach (DataRow row in ds.Tables[1].Rows)
                {
                    /* Setting up the columns of the results. */
                    if (!string.IsNullOrEmpty(row.ItemArray[0].ToString()))
                    {
                        ds2.Tables[0].Columns.Add(row.ItemArray[0].ToString());
                        continue;
                    }

                    /* Reading results... */
                    //for (int i = 0; i < ds2.Tables[0].Columns.Count; i++)
                    //{
                    //    DataRow newRow = ds2.Tables[0].NewRow();

                    //    //newRow[0] = ds.Tables[0].Columns[i].Caption;
                    //    newRow[i] = row.ItemArray[4];
                    //    for (int j = 0; j < ds.Tables[1].Rows.Count; j++)
                    //        newRow[j + 1] = ds.Tables[1].Rows[j][i];
                    //    ds2.Tables[0].Rows.Add(newRow);
                    //}

                    if (ds2.Tables[0].Rows.Count == 0) /* No rows have been added */
                    {
                        DataRow newRow = ds2.Tables[0].NewRow();
                        ds2.Tables[0].Rows.Add(newRow);
                    }

                    if (nub == ds2.Tables[0].Columns.Count-1)
                    {
                        /* last item to add in the row */
                        ds2.Tables[0].Rows[ds2.Tables[0].Rows.Count - 1][nub] = row.ItemArray[2];

                        //ResponseBox.Text += "row.ItemArray[2] = " + row.ItemArray[2].ToString() + newline + "ds2 rows.itemArray[nub] = " +
                          //  ds2.Tables[0].Rows[ds2.Tables[0].Rows.Count - 1].ItemArray[nub] + newline;

                        /* Add a new row */
                        DataRow nextRow = ds2.Tables[0].NewRow();
                        ds2.Tables[0].Rows.Add(nextRow);

                        
                        nub = 0; // reset
                    }
                    else
                    {
                        ds2.Tables[0].Rows[ds2.Tables[0].Rows.Count - 1][nub] = row.ItemArray[2];
                        //ResponseBox.Text += "row.ItemArray[2] = " + row.ItemArray[2].ToString() + newline + "ds2 rows.itemArray[nub] = " + 
                          //  ds2.Tables[0].Rows[ds2.Tables[0].Rows.Count-1].ItemArray[nub] + newline;

                        nub++;
                    }
                }

                /* Delete the last row */
                ds2.Tables[0].Rows.Remove(ds2.Tables[0].Rows[ds2.Tables[0].Rows.Count - 1]);

                dataGridView1.DataSource = ds2.Tables[0]; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }

        /**
         * <summary>This method determines what to set the runtime mode to, based on the radio buttons.</summary>
         * <remarks>1 of the radio buttons must be selected. The default is LOGICAL mode.</remarks>
         * <returns>A string that holds the runtime mode code value that has been selected.</returns>
         */
        private String ascertainRuntimeMode()
        {
            String result = "0";
            if (rbtODBC.Checked)
                result = "1";
            else if (rbtDISPLAY.Checked)
                result = "2";

            return result;
        }

        /**
         * <summary>This is run when the configure login info menu option is selected.</summary>
         * <remarks>This will reset the login info credentials so that they may be configured while running the application rather than at
         * runtime.</remarks>
         */
        private void configureLoginInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPrompt.loginInfo myLoginInfo = LoginPrompt.ShowDialog();
            systemCode = myLoginInfo.systemCode;
            userName = myLoginInfo.userName;
            password = myLoginInfo.passWord;
        }

        /**
         * <summary>Build logininfo object for the web service.</summary>
         * <remarks>Note: this is the LoginInfo class that is used by the web service and not the loginInfo class that is used for modifying the 
         * login information when filing the web service through the menu option.</remarks>
         * <returns>Returns an object of the class LoginInfo that will be filed to the XMLService web service.</returns>
         */
        private XMLService.LoginInfo buildLoginInfo()
        {
            var loginInfo = new XMLService.LoginInfo();
            loginInfo.systemCode = systemCode;
            loginInfo.userName = userName;
            loginInfo.password = password;

            return loginInfo;
        }

        /**
         * <summary>Menu option that will show an About dialog for the program. It contains my name, e-mail and the current version of the
         * program.</summary>
         */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Simply shows ad hoc information about this program. */
            AboutDialog.ShowDialog();
        }

        /**
         * <summary>This is the about dialog for this desktop app</summary>
         * */
        public static class AboutDialog
        {
            public static void ShowDialog()
            {
                Form aboutDialog = new Form();
                aboutDialog.Width = 325;
                aboutDialog.Height = 225;
                aboutDialog.Text = "About";
                String aNewLine = System.Environment.NewLine;
                String aboutInfo = "Cache XMLService Caller" + aNewLine + "Created by Barry Gaffey <bgaffey AT ssmh DOT org>" + aNewLine + "Version: " + Properties.Resources.VersionInfo;
                TextBox aboutText = new TextBox() { Left = 25, Top = 20, Multiline = true, ReadOnly = true, Text = aboutInfo, Size = new System.Drawing.Size(275,120) };
                Button btOK = new Button() { Text = "Ok", Left =180, Width = 100, Top = 150 };
                btOK.Click += (sender, e) => { aboutDialog.Close(); };
                aboutDialog.AcceptButton = btOK;
                aboutDialog.Controls.Add(btOK);
                aboutDialog.Controls.Add(aboutText);
                aboutDialog.ShowDialog();
            }
        }
        /**
         * <summary>This is a class definition for the login credentials for the database. This information is used to log into the database.
         * It also contains a method which prompts the user for these login credentials.</summary>
         * */
        public static class LoginPrompt
        {
            public class loginInfo
            {
                public string systemCode { get; set; }
                public string userName { get; set; }
                public string passWord { get; set; }

                public loginInfo()
                {
                    systemCode = "";
                    userName = "";
                    passWord = "";
                }

                public loginInfo(string syscode, string user, string pword)
                {
                    systemCode = syscode;
                    userName = user;
                    passWord = pword;
                }

                public loginInfo(loginInfo previousLoginInfo) : this(previousLoginInfo.systemCode, previousLoginInfo.userName, previousLoginInfo.passWord)
                {
                }
            }

            public static loginInfo ShowDialog()
            {
                Form loginPrompt = new Form();
                loginPrompt.Width = 325;
                loginPrompt.Height = 225;
                loginPrompt.Text = "Login";
                loginPrompt.Location = new System.Drawing.Point(14, 133);
                //loginInfo st_Login = new loginInfo();
                Label lblLogin = new Label() { Left = 25, Top = 20, Text = "SYSTEM CODE: " };
                TextBox tbx_entry1 = new TextBox() { Left = 150, Top = 20, TextAlign = System.Windows.Forms.HorizontalAlignment.Right, Size = new System.Drawing.Size(75,20)};
                Label lblLogin2 = new Label() { Left = 25, Top = 60, Text = "USER NAME: " };
                TextBox tbx_entry2 = new TextBox() { Left = 150, Top = 60, TextAlign = System.Windows.Forms.HorizontalAlignment.Right, Size = new System.Drawing.Size(75,20)};
                Label lblLogin3 = new Label() { Left = 25, Top = 100, Text = "PASSWORD: " };
                TextBox tbx_entry3 = new TextBox() { Left = 150, Top = 100, UseSystemPasswordChar = true, Size = new System.Drawing.Size(75,20), TextAlign = System.Windows.Forms.HorizontalAlignment.Right };
                Button btOK = new Button() { Text = "Ok", Left = 180, Width = 100, Top = 150 };
                btOK.Click += (sender, e) => { loginPrompt.Close(); };
                loginPrompt.AcceptButton = btOK;
                loginPrompt.Controls.Add(lblLogin);
                loginPrompt.Controls.Add(tbx_entry1);
                loginPrompt.Controls.Add(lblLogin2);
                loginPrompt.Controls.Add(tbx_entry2);
                loginPrompt.Controls.Add(lblLogin3);
                loginPrompt.Controls.Add(tbx_entry3);
                loginPrompt.Controls.Add(btOK);
                loginPrompt.ShowDialog();
                loginInfo st_Login = new loginInfo(tbx_entry1.Text, tbx_entry2.Text, tbx_entry3.Text);
                return st_Login;
            }
        }

        /**
         * <summary>A Help Dialog box that displays some basic help information on how to use the program.</summary>
         * */
        public static class HelpDialog
        {
            public static void ShowDialog()
            {
                Form helpDialog = new Form();
                helpDialog.Width = 325;
                helpDialog.Height = 225;
                helpDialog.Text = "Help";
                String aNewLine = System.Environment.NewLine;
                String helpInfo = "Parameters:" + aNewLine + "SQL: It's a SQL query text." + aNewLine + "Runtime Mode: Use this property to set the SQL runtime mode for the query to be executed."
                    + aNewLine + "LOGICAL mode is the default." + aNewLine + "This web method will return an xml resultset.";
                TextBox helpText = new TextBox() { Left = 25, Top = 20, Multiline = true, ReadOnly = true, Text = helpInfo, Size = new System.Drawing.Size(275, 120) };
                Button btOK = new Button() { Text = "Ok", Left = 180, Width = 100, Top = 150 };
                btOK.Click += (sender, e) => { helpDialog.Close(); };
                helpDialog.AcceptButton = btOK;
                helpDialog.Controls.Add(btOK);
                helpDialog.Controls.Add(helpText);
                helpDialog.ShowDialog();
            }
        }

        /**
         * <summary>This is a menu option that will show some help documentation that was paraphrased from Netsmart's own publicly documented information on
         * this web service.</summary>
         */
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /* Show help information for this program. */
            HelpDialog.ShowDialog();
        }

        /**
         * <summary>This will export the returned XML data to an XML file.</summary>
         */
        private void exportToXMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show ths saveFileDialog when the user selects this menu item. Set the default extension and filters.
            saveXMLFileDialog.DefaultExt = ".xml";
            saveXMLFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveXMLFileDialog.ShowDialog();
        }

        /**
         * <summary>This will do the file saving. It detemines the filename and path and then write the current XML data to that file.</summary>
         * <remarks>This is called by the showDialog() method.</remarks>
         */
        private void saveXMLFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveXMLFileDialog.FileName;
            File.WriteAllText(name, XMLdata2export);
        }

        private void displayXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayXMLToolStripMenuItem.Checked = !displayXMLToolStripMenuItem.Checked;
            dataGridView1.Visible = !displayXMLToolStripMenuItem.Checked;
            ResponseBox.Visible = displayXMLToolStripMenuItem.Checked;
        }
    }

}
