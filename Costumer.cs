using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_infor
{
    //class
    public class Costumer
    {
        //atributes
        private int id;
        private string name;
        private string lastname;
        private string cpf;
        private string cell;
        private string email;
        private string confemail;
        private string passwd;
        private string confpasswd;
        private DateTime born;

        public Costumer()
        {
            this.id = 0;
            this.name = "";
            this.lastname = "";
            this.cpf = "";
            this.cell = "";
            this.email = "";
            this.confemail = "";
            this.passwd = "";
            this.confpasswd = "";
            this.born = DateTime.Now;
        }

        public Costumer(int p_id,
                        string p_name,
                        string p_lastname,
                        string p_cpf,
                        string p_cell,
                        string p_email,
                        string p_confemail,
                        string p_passwd,
                        string p_confpasswd,
                        DateTime p_born)
        {
            this.id = p_id;
            this.name = p_name;
            this.lastname = p_lastname;
            this.cpf = p_cpf;
            this.cell = p_cell;
            this.email = p_email;
            this.confemail = p_confemail;
            this.passwd = p_passwd;
            this.confpasswd = p_confpasswd;
            this.born = p_born;
        }


        //get~set identity
        public int getId() { return this.id; }
        public void setId(int p_id) { this.id = p_id; }
        //get~set name
        public string getName() { return this.name; }
        public void setName(string p_name) { this.name = p_name; }
        //get~set lastname
        public string getLastn() { return this.lastname; }
        public void setLastn(string p_lastname) { this.lastname = p_lastname; }
        //get~set cpf
        public string getCpf() { return this.cpf; }
        public void setCpf(string p_cpf) { this.cpf = p_cpf; }
        //get~set cellphone
        public string getCell() { return this.cell; }
        public void setCell(string p_cell) { this.cell = p_cell; }
        //get~set email
        public string getEmail() { return this.email; }
        public void setEmail(string p_email) { this.email = p_email; }
        //get~set email confirmation
        public string getConfemail() { return this.confemail; }
        public void setConfemail(string p_confemail) { this.confemail = p_confemail; }
        //get~set password
        public string getPasswd() { return this.passwd; }
        public void setPasswd(string p_passwd) { this.passwd = p_passwd; }
        //get~set password confirmation
        public string getConfpasswd() { return this.confpasswd; }
        public void setConfpasswd(string p_confpasswd) { this.confpasswd = p_confpasswd; }
        //get~set birth date
        public DateTime getBorn() { return this.born; }
        public void setBorn(DateTime p_born) { this.born = p_born; }
    }
}