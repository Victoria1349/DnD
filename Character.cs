using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    [DataContract]
    public class Character
    {
        [DataMember]
        public string name;
        [DataMember]
        public string clas;
        [DataMember]
        public string history;
        [DataMember]
        public string race;
        [DataMember]
        public string character;
        [DataMember]
        public string experience;
        [DataMember]
        public string gamerName;

        [DataMember]
        public int straight;
        [DataMember]
        public int straightMax;
        [DataMember]
        public int dexterity;
        [DataMember]
        public int dexterityMax;
        [DataMember]
        public int body;
        [DataMember]
        public int bodyMax;
        [DataMember]
        public int intel;
        [DataMember]
        public int intelMax;
        [DataMember]
        public int wisdom;
        [DataMember]
        public int wisdomMax;
        [DataMember]
        public int charisma;
        [DataMember]
        public int charismaMax;

        [DataMember]
        public int vdohn;
        [DataMember]
        public int master;
        [DataMember]
        public int vnimat;

        [DataMember]
        public int KD;
        [DataMember]
        public int iniciat;
        [DataMember]
        public int skor;
        [DataMember]
        public int hitMax;
        [DataMember]
        public int hitNow;
        [DataMember]
        public int vremHitMax;
        [DataMember]
        public int vremHitNow;
        [DataMember]
        public int sucsess;
        [DataMember]
        public int notSuc;

        [DataMember]
        public int med;
        [DataMember]
        public int silver;
        [DataMember]
        public int elect;
        [DataMember]
        public int gold;
        [DataMember]
        public int platinum;


    }
}
