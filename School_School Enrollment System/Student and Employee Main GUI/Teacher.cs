namespace School_School_Enrollment_System
{
    public partial class Teacher : Form
    {
        bool expandsidebar;
        bool expanddropdown;
        public Teacher()
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

        private void dropdowntimer_Tick(object sender, EventArgs e)
        {
            if (expanddropdown)
            {
                teachersloaddropdown.Height += 10;
                if (teachersloaddropdown.Height == teachersloaddropdown.MaximumSize.Height)
                {
                    expanddropdown = false;
                    dropdowntimer.Stop();
                }
            }
            else
            {
                teachersloaddropdown.Height -= 10;
                if (teachersloaddropdown.Height == teachersloaddropdown.MinimumSize.Height)
                {
                    expanddropdown = true;
                    dropdowntimer.Stop();
                }
            }
        }

        private void teachersloadbutton_Click(object sender, EventArgs e)
        {
            dropdowntimer.Start(); 
        }
    }
}
