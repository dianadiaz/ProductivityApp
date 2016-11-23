namespace ProductivityApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductivityApp = new System.Windows.Forms.TabControl();
            this.InventoryTab = new System.Windows.Forms.TabPage();
            this.TimeSheet = new System.Windows.Forms.TabPage();
            this.AddressBook = new System.Windows.Forms.TabPage();
            this.Tasks = new System.Windows.Forms.TabPage();
            this.Budget = new System.Windows.Forms.TabPage();
            this.Calculator = new System.Windows.Forms.TabPage();
            this.ProductivityApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductivityApp
            // 
            this.ProductivityApp.AccessibleDescription = "ProductivityApp";
            this.ProductivityApp.AccessibleName = "ProductivityApp";
            this.ProductivityApp.Controls.Add(this.InventoryTab);
            this.ProductivityApp.Controls.Add(this.TimeSheet);
            this.ProductivityApp.Controls.Add(this.AddressBook);
            this.ProductivityApp.Controls.Add(this.Tasks);
            this.ProductivityApp.Controls.Add(this.Budget);
            this.ProductivityApp.Controls.Add(this.Calculator);
            this.ProductivityApp.Location = new System.Drawing.Point(13, 13);
            this.ProductivityApp.Name = "ProductivityApp";
            this.ProductivityApp.SelectedIndex = 0;
            this.ProductivityApp.Size = new System.Drawing.Size(1240, 620);
            this.ProductivityApp.TabIndex = 0;
            // 
            // InventoryTab
            // 
            this.InventoryTab.AccessibleDescription = "Inventory";
            this.InventoryTab.AccessibleName = "Inventory";
            this.InventoryTab.Location = new System.Drawing.Point(4, 22);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryTab.Size = new System.Drawing.Size(1232, 594);
            this.InventoryTab.TabIndex = 0;
            this.InventoryTab.Text = "Inventory";
            this.InventoryTab.UseVisualStyleBackColor = true;
            // 
            // TimeSheet
            // 
            this.TimeSheet.AccessibleDescription = "TimeSheet";
            this.TimeSheet.AccessibleName = "TimeSheet";
            this.TimeSheet.Location = new System.Drawing.Point(4, 22);
            this.TimeSheet.Name = "TimeSheet";
            this.TimeSheet.Padding = new System.Windows.Forms.Padding(3);
            this.TimeSheet.Size = new System.Drawing.Size(1232, 594);
            this.TimeSheet.TabIndex = 1;
            this.TimeSheet.Text = "Time Sheet";
            this.TimeSheet.UseVisualStyleBackColor = true;
            // 
            // AddressBook
            // 
            this.AddressBook.AccessibleDescription = "AddressBook";
            this.AddressBook.AccessibleName = "AddressBook";
            this.AddressBook.Location = new System.Drawing.Point(4, 22);
            this.AddressBook.Name = "AddressBook";
            this.AddressBook.Padding = new System.Windows.Forms.Padding(3);
            this.AddressBook.Size = new System.Drawing.Size(1232, 594);
            this.AddressBook.TabIndex = 2;
            this.AddressBook.Text = "Address Book";
            this.AddressBook.UseVisualStyleBackColor = true;
            // 
            // Tasks
            // 
            this.Tasks.AccessibleDescription = "Tasks";
            this.Tasks.AccessibleName = "Tasks";
            this.Tasks.Location = new System.Drawing.Point(4, 22);
            this.Tasks.Name = "Tasks";
            this.Tasks.Padding = new System.Windows.Forms.Padding(3);
            this.Tasks.Size = new System.Drawing.Size(1232, 594);
            this.Tasks.TabIndex = 3;
            this.Tasks.Text = "Tasks";
            this.Tasks.UseVisualStyleBackColor = true;
            // 
            // Budget
            // 
            this.Budget.AccessibleDescription = "Budget";
            this.Budget.AccessibleName = "Budget";
            this.Budget.Location = new System.Drawing.Point(4, 22);
            this.Budget.Name = "Budget";
            this.Budget.Padding = new System.Windows.Forms.Padding(3);
            this.Budget.Size = new System.Drawing.Size(1232, 594);
            this.Budget.TabIndex = 4;
            this.Budget.Text = "Budget";
            this.Budget.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.Calculator.AccessibleDescription = "Calculator";
            this.Calculator.AccessibleName = "Calculator";
            this.Calculator.Location = new System.Drawing.Point(4, 22);
            this.Calculator.Name = "Calculator";
            this.Calculator.Padding = new System.Windows.Forms.Padding(3);
            this.Calculator.Size = new System.Drawing.Size(1232, 594);
            this.Calculator.TabIndex = 5;
            this.Calculator.Text = "Calculator";
            this.Calculator.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 645);
            this.Controls.Add(this.ProductivityApp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ProductivityApp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ProductivityApp;
        private System.Windows.Forms.TabPage InventoryTab;
        private System.Windows.Forms.TabPage TimeSheet;
        private System.Windows.Forms.TabPage AddressBook;
        private System.Windows.Forms.TabPage Tasks;
        private System.Windows.Forms.TabPage Budget;
        private System.Windows.Forms.TabPage Calculator;
    }
}

