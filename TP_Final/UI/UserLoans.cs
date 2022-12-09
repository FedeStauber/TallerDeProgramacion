using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Final.IO;

namespace TP_Final.UI
{
    public partial class UserLoans : Form
    {       
        private List<LoanDTO> iLoanList; 
        public UserLoans(UserDTO pUser)
        {
            InitializeComponent();        
            this.iLoanList = LibraryManager.UserLoansHistory(pUser);
            this.AssignElements();
        }

        private void AssignElements()
        {           
            dataGridView1.DataSource = iLoanList;
        }
    }
}
