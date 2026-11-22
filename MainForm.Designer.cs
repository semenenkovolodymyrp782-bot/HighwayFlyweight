namespace HighwayFlyweight
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnAddTruck = new System.Windows.Forms.Button();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.pnlRoad = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(35, 60);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(112, 23);
            this.btnAddCar.TabIndex = 0;
            this.btnAddCar.Text = "Додати легковий";
            this.btnAddCar.UseVisualStyleBackColor = true;
            // 
            // btnAddTruck
            // 
            this.btnAddTruck.Location = new System.Drawing.Point(35, 103);
            this.btnAddTruck.Name = "btnAddTruck";
            this.btnAddTruck.Size = new System.Drawing.Size(131, 23);
            this.btnAddTruck.TabIndex = 1;
            this.btnAddTruck.Text = "Додати вантажівку";
            this.btnAddTruck.UseVisualStyleBackColor = true;
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(35, 147);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(131, 23);
            this.btnAddBus.TabIndex = 2;
            this.btnAddBus.Text = "Додати автобус";
            this.btnAddBus.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(35, 210);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Почати рух";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(46, 273);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // pnlRoad
            // 
            this.pnlRoad.Location = new System.Drawing.Point(355, 77);
            this.pnlRoad.Name = "pnlRoad";
            this.pnlRoad.Size = new System.Drawing.Size(503, 294);
            this.pnlRoad.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1034, 641);
            this.Controls.Add(this.pnlRoad);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.btnAddTruck);
            this.Controls.Add(this.btnAddCar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1050, 680);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnAddTruck;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Panel pnlRoad;
        private System.Windows.Forms.Timer timer1;
    }
}
