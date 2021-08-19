  private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2,n3, PT;

            n1 = Convert.ToDouble(txtCarga.Text);
            n2 = Convert.ToDouble(txtPeso.Text);
            n3 = Convert.ToDouble(txtAltura.Text);

            PT= (n1 + n2);

            if( PT<= 2){
               if(n3 <= 4)
                {
                    MessageBox.Show("Este veículo pode passar em todas as pontes com o seu peso atual.");
                }
               else
                {
                    MessageBox.Show("Este veículo não poderá ir para a ponte z");
                }
            }
            else if (PT>= 2 && PT<= 7)
            {
                if (n3 < 9)
                {
                    MessageBox.Show("Voce não pode ir na ponte Rio Negro mas pode ir na ponte y");
                }
                else
                {
                    MessageBox.Show("Este veículo não poderá ir em 2 pontes mas pode ir na ponte x");
                }

            }
            else if(PT<= 9 && PT>= 7)
            {
                if (n3 < 15)
                {
                    MessageBox.Show("Este veículo pode ir somente na ponte x");
                }
                else
                {
                    MessageBox.Show("Este veículo não pode ir a nenhuma ponte");
                }
            }
            else
            {
                MessageBox.Show("Este veículo não pode ir a nenhuma ponte");
            }
        }


    }
}