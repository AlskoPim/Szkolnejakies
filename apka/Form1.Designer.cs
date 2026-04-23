namespace apka {
    partial class Form1 {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnObraz;
        private System.Windows.Forms.Button btnDalej;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        protected override void Dispose(bool disposing) {
            if (disposing && components != null) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            txtEmail = new TextBox();
            btnObraz = new Button();
            btnDalej = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();

            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // pole imie
            txtImie.Location = new Point(30, 72);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(200, 23);
            txtImie.TabIndex = 0;
            txtImie.TextChanged += textBox_TextChanged;

            // pole nazwisko
            txtNazwisko.Location = new Point(30, 124);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(200, 23);
            txtNazwisko.TabIndex = 1;
            txtNazwisko.TextChanged += textBox_TextChanged;

            // pole email
            txtEmail.Location = new Point(30, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += textBox_TextChanged;

            // guzik obraz
            btnObraz.Location = new Point(30, 241);
            btnObraz.Name = "btnObraz";
            btnObraz.Size = new Size(200, 30);
            btnObraz.TabIndex = 3;
            btnObraz.Text = "OBRAZ";
            btnObraz.Click += btnObraz_Click;

            // guzik dalej
            btnDalej.Location = new Point(30, 277);
            btnDalej.Name = "btnDalej";
            btnDalej.Size = new Size(200, 30);
            btnDalej.TabIndex = 4;
            btnDalej.Text = "DALEJ";
            btnDalej.Click += btnDalej_Click;

            // obrazek
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(300, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;

            // pierwszy label
            label1.Location = new Point(30, 46);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 6;
            label1.Text = "Imię";

            // drugi label
            label2.Location = new Point(30, 98);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            label2.Text = "Nazwisko";

            // trzeci label
            label3.Location = new Point(30, 150);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 8;
            label3.Text = "Email";

            // Form1
            ClientSize = new Size(750, 400);
            Name = "Form1";
            Text = "Formularz";

            Controls.Add(txtImie);
            Controls.Add(txtNazwisko);
            Controls.Add(txtEmail);
            Controls.Add(btnObraz);
            Controls.Add(btnDalej);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}