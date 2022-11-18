using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_infor
{
    //###### CLASS COSTUMER ######
    public class Costumer
    {
        //###### ATRIBUTES DECLARATION ######
        private int id;
        private string name;
        private string lastname;
        private string cpf;
        private string cell;
        private string email;
        private string confemail;
        private string passwd;
        private string confpasswd;
        private string born;

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
            this.born = "";
        }

        //###### CONSTRUCTOR DECLARATION ######
        public Costumer(int p_id,
                        string p_name,
                        string p_lastname,
                        string p_cpf,
                        string p_cell,
                        string p_email,
                        string p_confemail,
                        string p_passwd,
                        string p_confpasswd,
                        string p_born)
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


        //###### GET~SET IDENTITY ######
        public int getId() { return this.id; }
        public void setId(int p_id) { this.id = p_id; }

        //###### GET~SET NAME ######
        public string getName() { return this.name; }
        public void setName(string p_name) { this.name = p_name; }

        //###### GET~SET LAST NAME ######
        public string getLastn() { return this.lastname; }
        public void setLastn(string p_lastname) { this.lastname = p_lastname; }

        //###### GET~SET CPF ######
        public string getCpf() { return this.cpf; }
        public void setCpf(string p_cpf) { this.cpf = p_cpf; }
        
        //###### GET~SET CELL PHONE ######
        public string getCell() { return this.cell; }
        public void setCell(string p_cell) { this.cell = p_cell; }
        
        //###### GET~SET EMAIL ######
        public string getEmail() { return this.email; }
        public void setEmail(string p_email) { this.email = p_email; }
        
        //###### GET~SET EMAIL CONFIRMATION ######
        public string getConfemail() { return this.confemail; }
        public void setConfemail(string p_confemail) { this.confemail = p_confemail; }
        
        //###### GET~SET PASSWORD ######
        public string getPasswd() { return this.passwd; }
        public void setPasswd(string p_passwd) { this.passwd = p_passwd; }
        
        //###### GET~SET PASSWORD CONFIRMATION ######
        public string getConfpasswd() { return this.confpasswd; }
        public void setConfpasswd(string p_confpasswd) { this.confpasswd = p_confpasswd; }
        
        //###### GET~SET BIRTH DATE ######
        public string getBorn() { return this.born; }
        public void setBorn(string p_born) { this.born = p_born; }
    }
}