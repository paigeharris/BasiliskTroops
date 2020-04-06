﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Overlay;
using TaleWorlds.CampaignSystem.Character;
using TaleWorlds.SaveSystem;
using static TaleWorlds.CampaignSystem.SettlementComponent;

namespace BasiliskTroops
{
    public class TroopProperties
    {

        [SaveableField(1)]
        public string settlementID;

        [SaveableField(2)]
        public MobileParty militia;

        [SaveableField(3)]
        public MobileParty nobles;

        [SaveableField(4)]
        public bool paid;

        public TroopProperties(string settlementID, MobileParty militia, MobileParty nobles, bool paid = false)
        {
            this.settlementID = settlementID;
            this.militia = militia;
            this.nobles = nobles;
            this.paid = false;
        }

        public Settlement getSelf()
        {
            return Settlement.Find(this.settlementID);
        }

        public int getCost
        {
            get
            {
                return (int)Math.Ceiling(getSelf().Town.Prosperity * 2);
            }
        }
        
        public int getProsperity
        {
            get
            {
                return (int)Math.Ceiling(getSelf().Town.Prosperity);
            }
        }

    }
}
