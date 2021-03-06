﻿using HearthStone_Rip_Off.Cards.Creatures;
using HearthStone_Rip_Off.Cards.Creatures.List_of_Creatures;
using HearthStone_Rip_Off.Cards.Spells.List_of_Spells;
using HearthStone_Rip_Off.Contracts;
using HearthStone_Rip_Off.Engine_Stuffs;
using System;

namespace HearthStone_Rip_Off.Factory
{
    public static class CardFactory
    {
        public static ICard CreateCard(string cardToBeAdded)
        {
            cardToBeAdded = cardToBeAdded.ToLower();
            switch (cardToBeAdded)
            {
                case "aldorpeacekeeper":
                    {
                        return new AldorPeacekeeper();
                    }
                case "alexstrasza":
                    {
                        return new Alexstrasza();
                    }
                case "ancientbrewmaster":
                    {
                        return new AncientBrewmaster();
                    }
                case "ancientmage":
                    {
                        return new AncientMage();
                    }
                case "archmageantonidas":
                    {
                        return new ArchmageAntonidas();
                    }
                case "auchenaisoulpriest":
                    {
                        return new AuchenaiSoulpriest();
                    }
                case "cenarius":
                    {
                        return new Cenarius();
                    }
                case "chillwindyeti":
                    {
                        return new ChillWindYeti();
                    }
                case "deathwing":
                    {
                        return new Deathwing();
                    }
                case "doomguard":
                    {
                        return new Doomguard();
                    }
                case "druidoftheclaw":
                    {
                        return new DruidOfTheClaw();
                    }
                case "emperorcobra":
                    {
                        return new EmperorCobra();
                    }
                case "manawyrm":
                    {
                        return new ManaWyrm();
                    }
                case "ogre":
                    {
                        return new Ogre();
                    }
                case "swampooze":
                    {
                        return new SwampOoze();
                    }
                case "tiger":
                    {
                        return new Tiger();
                    }
                case "waterelemental":
                    {
                        return new WaterElemental();
                    }
                case "fireball":
                    {
                        return new FireBall();
                    }
                case "fireblast":
                    {
                        return new FireBlast();
                    }
                case "frostbolt":
                    {
                        return new FrostBolt();
                    }
                case "holysmite":
                    {
                        return new HolySmite();
                    }
                case "lightningbolt":
                    {
                        return new LightningBolt();
                    }
                case "meteorshower":
                    {
                        return new MeteorShower();
                    }
                case "moonfire":
                    {
                        return new MoonFire();
                    }
                case "shadowbolt":
                    {
                        return new ShadowBolt();
                    }
                default:
                    {
                        Console.WriteLine("This Card doesn't exist");
                        DeckCollectionManagement.ManageDeckCollection();
                        return new ShadowBolt();
                    }
            }
        }
    }
}