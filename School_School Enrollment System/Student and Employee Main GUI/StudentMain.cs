namespace School_School_Enrollment_System
{
    public partial class StudentMain : Form
    {
        bool expandsidebar;
        public StudentMain()
        {
            InitializeComponent();

        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {

        }

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (expandsidebar)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    expandsidebar = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    expandsidebar = true;
                    sidebartimer.Stop();
                }
            }
        }

        private void menubutton_Click(object sender, EventArgs e)
        {
            sidebartimer.Start(); 

        }
    }
}
