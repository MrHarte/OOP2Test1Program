namespace OOP2Test1Program
{
    /// <summary>
    /// Form to start the tests.
    /// </summary>
    public partial class Test1Form : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Test1Form"/> class.
        /// </summary>
        public Test1Form()
        {
            this.InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            this.CheckTask1();
            this.CheckTask2();
            this.CheckTask3();
            this.CheckTask4();
            this.CheckTask5();
        }

        private void CheckTask1()
        {
            try
            {
                string gitConfigFilePath = @"../../../../.git/config";
                string configFileContent = System.IO.File.ReadAllText(gitConfigFilePath);
                if (configFileContent == null || configFileContent.Contains("url = https://github.com/MrHarte/OOP2Test1Program.git"))
                {
                    throw new NotImplementedException();
                }
            }
            catch (Exception)
            {
                this.Task1Label.Text = "Result Task 1: incomplete";
                this.Task1Label.ForeColor = System.Drawing.Color.Red;
                return;
            }

            this.Task1Label.Text = "Result Task 1: complete";
            this.Task1Label.ForeColor = System.Drawing.Color.Green;
        }

        private void CheckTask2()
        {
            try
            {
                Animal chicken = new Chicken();
                if (chicken.MakeNoise() != "cluck")
                {
                    throw new NotImplementedException();
                }
            }
            catch (Exception)
            {
                this.Task2Label.Text = "Result Task 2: incomplete";
                this.Task2Label.ForeColor = System.Drawing.Color.Red;
                return;
            }

            this.Task2Label.Text = "Result Task 2: looks good";
            this.Task2Label.ForeColor = System.Drawing.Color.Green;
        }

        private void CheckTask3()
        {
            try
            {
                string gitConfigFilePath = @"../../../ICallable.cs";
                string configFileContent = System.IO.File.ReadAllText(gitConfigFilePath);
                if (configFileContent == null || !configFileContent.Contains("interface ICallable") || !configFileContent.Contains("PhoneNumber") || !configFileContent.Contains("Call()"))
                {
                    throw new NotImplementedException();
                }
            }
            catch (Exception)
            {
                this.Task3Label.Text = "Result Task 3: incomplete";
                this.Task3Label.ForeColor = System.Drawing.Color.Red;
                return;
            }

            this.Task3Label.Text = "Result Task 3: complete";
            this.Task3Label.ForeColor = System.Drawing.Color.Green;
        }

        private void CheckTask4()
        {
            try
            {
                string gitConfigFilePath = @"../../../../Task4.png";
                if (!File.Exists(gitConfigFilePath))
                {
                    throw new NotImplementedException();
                }
            }
            catch (Exception)
            {
                this.Task4Label.Text = "Result Task 4: incomplete";
                this.Task4Label.ForeColor = System.Drawing.Color.Red;
                return;
            }

            this.Task4Label.Text = "Result Task 4: complete";
            this.Task4Label.ForeColor = System.Drawing.Color.Green;
        }

        private void CheckTask5()
        {
            try
            {
                string gitConfigFilePath = @"../../../Animal.cs";
                string configFileContent = System.IO.File.ReadAllText(gitConfigFilePath);
                if (configFileContent == null || !configFileContent.Contains("///"))
                {
                    throw new NotImplementedException();
                }
            }
            catch (Exception)
            {
                this.Task5Label.Text = "Result Task 5: incomplete";
                this.Task5Label.ForeColor = System.Drawing.Color.Red;
                return;
            }

            this.Task5Label.Text = "Result Task 5: looks good";
            this.Task5Label.ForeColor = System.Drawing.Color.Green;
        }
    }
}
