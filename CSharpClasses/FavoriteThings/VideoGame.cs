using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.FavoriteThings
{
    class VideoGame
    {
        //Properties
        public string Title { get; set; }
        public GamingSystem GamingSystem { get; set; }
        public PC PC { get; private set; }
        public Nintendo Nintendo { get; private set; }
        public PlayStation PlayStation { get; private set; }
        public Xbox Xbox { get; private set; }
        public Sega Sega { get; private set; }

        //Constructor
        public VideoGame(GamingSystem gamingSystem, string title)
        {
            Title = title;

            GamingSystem = gamingSystem;

            switch (GamingSystem)
            {
                case GamingSystem.PC:
                    bool PCFound = false;
                    do
                    {
                        Console.WriteLine($"Windows, iOS, or Linux?");
                        string operatingSystem = Console.ReadLine();

                        if (operatingSystem.ToLower() == "windows")
                        {
                            PC = PC.Windows;
                            PCFound = true;

                        }
                        else if (operatingSystem.ToLower() == "ios")
                        {
                            PC = PC.iOS;
                            PCFound = true;

                        }
                        else if (operatingSystem.ToLower() == "linux")
                        {
                            PC = PC.Linux;
                            PCFound = true;

                        }
                        else
                        {
                            Console.WriteLine("Please choose one of the following.");
                            PCFound = false;
                        }

                    } while (PCFound == false);
                    break;

                case GamingSystem.Nintendo:
                    bool nintendoFound = false;
                    do
                    {
                        Console.WriteLine($"Which Nintindo console are you using?");
                        string nintendoConsole = Console.ReadLine();

                        switch (nintendoConsole.ToLower())
                        {
                            case "nintendo":
                                Nintendo = Nintendo.Nintendo;
                                nintendoFound = true;
                                break;
                            case "super nintendo":
                                Nintendo = Nintendo.SuperNintendo;
                                nintendoFound = true;
                                break;
                            case "nintendo 64":
                                Nintendo = Nintendo.Nintendo64;
                                nintendoFound = true;
                                break;
                            case "gamecube":
                                Nintendo = Nintendo.GameCube;
                                nintendoFound = true;
                                break;
                            case "wii":
                                Nintendo = Nintendo.Wii;
                                nintendoFound = true;
                                break;
                            case "switch":
                                Nintendo = Nintendo.Switch;
                                nintendoFound = true;
                                break;
                            default:
                                Console.WriteLine($"That {GamingSystem.ToString()} console doesn't seem to exist.");
                                nintendoFound = false;
                                break;
                        }

                    } while (nintendoFound == false);
                    break;

                case GamingSystem.PlayStation:
                    bool playstationFound = false;
                    do
                    {
                        Console.WriteLine($"Which PlayStation console are you using?");
                        string playstationConsole = Console.ReadLine();

                        switch (playstationConsole.ToLower())
                        {
                            case "playstation":
                                PlayStation = PlayStation.PlayStation;
                                playstationFound = true;
                                break;
                            case "playstation 2":
                                PlayStation = PlayStation.PlayStation2;
                                playstationFound = true;
                                break;
                            case "playstation 3":
                                PlayStation = PlayStation.PlayStation3;
                                playstationFound = true;
                                break;
                            case "playstation 4":
                                PlayStation = PlayStation.PlayStation4;
                                playstationFound = true;
                                break;
                            case "playstation 5":
                                PlayStation = PlayStation.PlayStation5;
                                playstationFound = true;
                                break;
                            default:
                                Console.WriteLine($"That {GamingSystem.ToString()} console doesn't seem to exist.");
                                playstationFound = false;
                                break;
                        }

                    } while (playstationFound == false);
                    break;

                case GamingSystem.Xbox:
                    bool xboxFound = false;
                    do
                    {
                        Console.WriteLine($"Which Xbox console are you using?");
                        string xboxConsole = Console.ReadLine();

                        switch (xboxConsole.ToLower())
                        {
                            case "xbox":
                                Xbox = Xbox.Xbox;
                                xboxFound = true;
                                break;
                            case "xbox 360":
                                Xbox = Xbox.Xbox360;
                                xboxFound = true;
                                break;
                            case "xbox one":
                                Xbox = Xbox.XboxOne;
                                xboxFound = true;
                                break;
                            case "xbox series x":
                                Xbox = Xbox.XboxSeriesX;
                                xboxFound = true;
                                break;
                            default:
                                Console.WriteLine($"That {GamingSystem.ToString()} console doesn't seem to exist.");
                                xboxFound = false;
                                break;
                        }

                    } while (xboxFound == false);
                    break;

                case GamingSystem.Sega:
                    bool segaFound = false;
                    do
                    {
                        Console.WriteLine($"Which Sega console are you using?");
                        string segaConsole = Console.ReadLine();

                        switch (segaConsole.ToLower())
                        {
                            case "master system":
                                Sega = Sega.MasterSystem;
                                segaFound = true;
                                break;
                            case "genesis":
                                Sega = Sega.Genesis;
                                segaFound = true;
                                break;
                            case "sega cd":
                                Sega = Sega.SegaCD;
                                segaFound = true;
                                break;
                            case "sega saturn":
                                Sega = Sega.SegaSaturn;
                                segaFound = true;
                                break;
                            case "dreamcast":
                                Sega = Sega.Dreamcast;
                                segaFound = true;
                                break;
                            default:
                                Console.WriteLine($"That {GamingSystem.ToString()} console doesn't seem to exist.");
                                segaFound = false;
                                break;
                        }

                    } while (segaFound == false);
                    break;
                default:
                    GamingSystem = 0;
                    break;
            }            
        }

        //Methods

        public void LoadGame()
        {
            string playingOn = "";

            switch (GamingSystem)
            {
                case GamingSystem.PC:
                    playingOn = PC.ToString();
                    break;
                case GamingSystem.Nintendo:
                    playingOn = Nintendo.ToString();
                    break;
                case GamingSystem.PlayStation:
                    playingOn = PlayStation.ToString();
                    break;
                case GamingSystem.Xbox:
                    playingOn = Xbox.ToString();
                    break;
                case GamingSystem.Sega:
                    playingOn = Sega.ToString();
                    break;
                default:
                    playingOn = "system that we are not sure about";
                    break;
            }
            Console.WriteLine($"You have loaded the game on a {playingOn}.");
        }

        public void Play()
        {
            Console.WriteLine($"You started playing {Title} on the {GamingSystem.ToString()}");
        }


    }

    enum GamingSystem
    {
        NoGamingSystemSelected,
        PC,
        Nintendo,
        PlayStation,
        Xbox,
        Sega
    }

    enum PC
    {
        NoPCSelected,
        Windows,
        iOS,
        Linux
    }

    enum Nintendo
    {
        NoNintendoSelected,
        Nintendo,
        SuperNintendo,
        Nintendo64,
        GameCube,
        Wii,
        Switch
    }
    enum PlayStation
    {
        NoPlaystationSelected,
        PlayStation,
        PlayStation2,
        PlayStation3,
        PlayStation4,
        PlayStation5
    }
    enum Xbox
    {
        NoXboxSelected,
        Xbox,
        Xbox360,
        XboxOne,
        XboxSeriesX
    }
    enum Sega
    {
        NoSegaSelected,
        MasterSystem,
        Genesis,
        SegaCD,
        SegaSaturn,
        Dreamcast
    }
}
