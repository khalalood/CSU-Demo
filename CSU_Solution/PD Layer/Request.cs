using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSU_Solution.PD_Layer
{
    public class Request
    {
        private string clubname, event_title, evnt_typ, Description, event_guestSpeaker, event_musicType, 
        event_foodCaterer, user_UserName;
        private int numatt, idRoom, event_length, length, event_feeAmount;
        private DateTime event_date;
        private bool event_fee, event_music, event_food, event_foodRisk, event_foodCatering, event_alcohol,
        Terms_Form, Terms_CSU;


        public Request()
        {

        }

        public Request(string cname, int numattnd)
        {

        }

        public Request(string title, DateTime eventdate, string type, string cname, int numattnd)
        {
            TITLE = title;
            DATE = eventdate;
            TYPE = type;
            CLUBNAME = cname;
            NUMBERATT = numattnd;
        }

        public Request(string cname, int numattnd, DateTime eventdate, int id_room, int eventlegth, string title,
        string type, string desc, string spkr, bool fee, int feeammt, bool music, string musictype, bool food, 
        bool fdrisk, bool foodcatering, string caterer, bool alc, bool terms1, bool terms2, string userUserName )
        {
            CLUBNAME = cname;
            NUMBERATT = numattnd;
            DATE = eventdate;
            ROOMID = id_room;
            LENGTH = eventlegth;
            TITLE = title;
            TYPE = type;
            DESCRIPTION = desc;
            SPEAKER = spkr;
            FEE = fee;
            FEEAMMOUNT = feeammt;
            MUSIC = music;
            MUSICTYPE = musictype;
            FOOD = food;
            FOODRISK = fdrisk;
            CATERING = foodcatering;
            CATERER = caterer;
            ALCOHOL = alc;
            CSUTERMS = terms1;
            FORMTERMS = terms2;
            USERUNAME = userUserName;
 

        }
        public string USERUNAME
        {
            get { return user_UserName; }
            set { user_UserName = value; }
        }
        public bool FORMTERMS
        {
            get { return Terms_Form; }
            set { Terms_Form = value; }
        }
        public bool CSUTERMS
        {
            get { return Terms_CSU; }
            set { Terms_CSU = value; }
        }
        public bool ALCOHOL
        {
            get { return event_alcohol; }
            set { event_alcohol = value; }
        }
        public string CATERER
        {
            get { return event_foodCaterer; }
            set { event_foodCaterer = value; }
        }
        public bool CATERING
        {
            get { return event_foodCatering; }
            set { event_foodCatering = value; }
        }
        public bool FOODRISK
        {
            get { return event_foodRisk; }
            set { event_foodRisk = value; }
        }
        public bool FOOD
        {
            get { return event_food; }
            set { event_food = value; }
        }
        public string MUSICTYPE
        {
            get { return event_musicType; }
            set { event_musicType = value; }
        }
        public bool MUSIC
        {
            get { return event_music; }
            set { event_music = value; }
        }
        public int FEEAMMOUNT
        {
            get { return event_feeAmount; }
            set { event_feeAmount = value; }
        }
        public bool FEE
        {
            get { return event_fee; }
            set { event_fee = value; }
        }
        public string SPEAKER
        {
            get { return event_guestSpeaker; }
            set { event_guestSpeaker = value; }
        }
        public string DESCRIPTION
        {
            get { return Description; }
            set { Description = value; }
        }
        public string TYPE
        {
            get { return evnt_typ; }
            set { evnt_typ = value; }
        }
        public string TITLE
        {
            get { return event_title; }
            set { event_title = value; }
        }
        public int LENGTH
        {
            get { return event_length; }
            set { event_length = value; }
        }
        public string CLUBNAME
        {
            get { return clubname; }  
            set { clubname = value; }
        }

        public int NUMBERATT
        {
            get { return numatt; }
            set { numatt = value; }
        }
        public DateTime DATE
        {
            get { return event_date; }
            set { event_date = value; }
        }

        public int ROOMID
        {
            get { return idRoom; }
            set { idRoom = value; }
        }
    }
}
