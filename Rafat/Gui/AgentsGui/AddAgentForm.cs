
using Rafat.Code.Helper;
using Rafat.Code.Models;
using Rafat.Core;
using Rafat.Data.EF;
using Rafat.Gui.LoadingGui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using FontAwesome6;

namespace Rafat.Gui.AgentsGui
{
    public partial class AddAgentForm : Form
    {
        private readonly IDataHelper<Agent> dataHelperForAgent;

        private readonly IDataHelper<SystemRecords> dataHelperForSystemRecords;
        private readonly Main main;
        private int id;
        private DateTime userCreatedDate;
        private const double ZoomStep = 0.5; // Step size for zooming

        private readonly AgentsUserControl? page;

        public AddAgentForm(Main main, int id)
        {
            InitializeComponent();

            dataHelperForAgent = new AgentEF();

            dataHelperForSystemRecords = new SystemRecordsEF();

            page = AgentsUserControl.Instance(main);
          

            this.Owner = main;

            this.main = main;
            this.id = id;

            if (this.id > 0)
            {
                SetDataForEdit();
            }
        }





        private bool IsValid()
        {
            if (
                txtAgFullname.Text.Length < 3 ||
                txtAgPhone.Text.Length < 3

                )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

      

        private async void Add()
        {
            // Set User
            Agent agent = new Agent
            {
                FullName = txtAgFullname.Text,
                Phone = txtAgPhone.Text,
                AddedDate = DateTime.Now.Date,
                ModifiedDate = DateTime.Now.Date,

                UserId = LocalUser.UserId
            };

            // Send Data to database
            var result = await Task.Run(() => dataHelperForAgent.Add(agent));
            if (result == "1")
            {
                

                // Success
                SystemRecordHelper.Add("Agent added", $"Agent({agent.DisplayName}) added Successfully");
                page.LoadData();
                ToastHelper.ShowAddToast();
                this.Close();
            }
            else
            {
                // Msg Box with result
                MessageBox.Show(result);
            }
        }

        private async void Edit()
        {

            // Set User
            Agent agent = new Agent
            {
                AgentId = id,
                FullName = txtAgFullname.Text,
                Phone = txtAgPhone.Text,
                AddedDate = userCreatedDate,
                ModifiedDate = DateTime.Now.Date,

                UserId = LocalUser.UserId

            };

            // Send Data to database
            var result = await Task.Run(() => dataHelperForAgent.Edit(agent));
            if (result == "1")
            {
                SystemRecordHelper.Add("Agent Edited", $"Agent({agent.DisplayName}) Updated Successfully");
                page.LoadData();
                ToastHelper.ShowEditToast();
                this.Close();
            }
            else
            {
                // Msg Box with result
                MessageBox.Show(result);
            }
        }



        private async void SetDataForEdit()
        {
            // Get Edit User Data
            var agent = await Task.Run(() => dataHelperForAgent.Find(id));
            if (agent != null)
            {
                txtAgFullname.Text = agent.FullName;
                txtAgPhone.Text = agent.Phone;
                userCreatedDate = agent.AddedDate;
            }



        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Check the fields
            if (!IsValid())
            {
                MsgHelper.ShowRequiredFields();
            }
            else
            {
                // Show Loading
             
                // Check Connection
                if (await Task.Run(() => dataHelperForAgent.IsCanConnect()))
                {
                    // Check Duplicated Item

                    string PhoneNumber = txtAgPhone.Text;

                    var result = await Task.Run(() => dataHelperForAgent
                        .GetAllData()
                        .Where(x => x.AgentId != id)
                        .FirstOrDefault(x => x.Phone == PhoneNumber) ?? new Agent());

                    if (result.AgentId > 0)
                    {
                        // Msg
                     
                        MsgHelper.ShowDuplicatedItems();
                    }
                    else
                    {
                        // Add
                        if (id == 0)
                        {
                            Add();
                        }
                        else
                        {
                            // Edit
                            Edit();
                        }
                    }


                }
                else
                {
                   
                    MsgHelper.ShowServerError();
                }

               
            }
        }


       
    }

}
