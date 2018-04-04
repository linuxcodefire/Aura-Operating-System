﻿/*
* PROJECT:          Aura Operating System Development
* CONTENT:          Help infos
* PROGRAMMERS:      Alexy DA CRUZ <dacruzalexy@gmail.com>
*                   Valentin Charbonnier <valentinbreiz@gmail.com>
*/

using Cosmos.HAL.PCInformation;
using System;

namespace Aura_OS.System.Translation
{
    class List_Translation
    {

        /// <summary>
        /// Display help on general commands.
        /// </summary>
        public static void _Help()
        {
            switch (Kernel.langSelected)
            {
                case "fr_FR":
                    Console.WriteLine("Commandes disponibles (1/2):");
                    Console.WriteLine("- shutdown (arrêt ACPI)");
                    Console.WriteLine("- reboot (redémarrage CPU)");
                    Console.WriteLine("- clear (efface la console)");
                    Console.WriteLine("- cd .. (pour naviguer dans le dossier parent)");
                    Console.WriteLine("- cd (pour aller à un dossier)");
                    Console.WriteLine("- dir (liste les fichiers et dossiers)");
                    Console.WriteLine("- ls (liste les fichiers et dossiers)");
                    Console.WriteLine("- cp (pour copier un fichier à une autre destination)");
                    Console.WriteLine("- mkdir (pour créer un dossier)");
                    Console.WriteLine("- rmdir (pour supprimer un dossier)");
                    Console.WriteLine("- mkfil (pour créer un fichier)");
                    Console.WriteLine("- rmfil (pour supprimer un fichier)");
                    Console.WriteLine("- edit (pour éditer un fichier)");
                    Console.WriteLine("- vol (list les volumes FAT)");
                    Console.WriteLine("- echo (affiche un echo)");
                    Console.WriteLine("- systeminfo (affiche des informations systeme)");
                    Console.WriteLine("- ver (pour afficher la version système)");
                    Console.WriteLine("- settings {args} (permet d'accéder aux paramètres)");
                    Console.WriteLine("- logout (permet de se déconnecter)");

                    Console.ReadKey(); //page 2
                    Console.WriteLine();
                    Console.WriteLine("Commandes disponibles (2/2):");
                    Console.WriteLine("- time (récupère la date et l'heure)");
                    Console.WriteLine("- ipconfig (affiche les informations réseau)");
                    Console.WriteLine("- snake (lance le jeu Snake)");
                    Console.WriteLine("- md5 (affiche le hash des arguments)");
                    Console.WriteLine("- crash (crash Aura)");
                    Console.WriteLine("- crashcpu (crash CPU)");
                    Console.WriteLine("- lspci (liste les appareils pci)");
                    Console.WriteLine("- beep (beep)");

                    Console.ReadKey();

                    break;

                case "en_US":
                    Console.WriteLine("Available commands (1/2):");
                    Console.WriteLine("- shutdown (to do an ACPI Shutdown)");
                    Console.WriteLine("- reboot (to do a CPU Reboot)");
                    Console.WriteLine("- clear (to clear the console)");
                    Console.WriteLine("- cd .. (to navigate to the parent folder)");
                    Console.WriteLine("- cd (to navigate to a folder)");
                    Console.WriteLine("- dir (to list directories and files)");
                    Console.WriteLine("- ls (to list directories and files)");
                    Console.WriteLine("- cp (to copy a file to an another destination)");
                    Console.WriteLine("- mkdir (to create a directory");
                    Console.WriteLine("- rmdir (to remove a directory)");
                    Console.WriteLine("- mkfil (to create a file)");
                    Console.WriteLine("- rmfil (to remove a file)");
                    Console.WriteLine("- edit (to edit a file)");
                    Console.WriteLine("- vol (to list volumes)");
                    Console.WriteLine("- echo (to echo text)");
                    Console.WriteLine("- systeminfo (to display system information)");
                    Console.WriteLine("- ver (to display system version)");
                    Console.WriteLine("- settings {args} (access to settings)");
                    Console.WriteLine("- logout (to disconnect)");
                    
                    Console.ReadKey(); //page 2 (19 elements per page)

                    Console.WriteLine();
                    Console.WriteLine("Available commands (2/2):");
                    Console.WriteLine("- time (to get time and date)");
                    Console.WriteLine("- ipconfig (to get network information)");
                    Console.WriteLine("- snake (launch the game Snake)");
                    Console.WriteLine("- md5 (to display hash of arguments)");
                    Console.WriteLine("- crash (crash Aura)");
                    Console.WriteLine("- crashcpu (crash CPU)");
                    Console.WriteLine("- lspci (list pci devices)");
                    Console.WriteLine("- beep (beep)");

                    Console.ReadKey();

                    break;

                case "nl_NL":
                    Console.WriteLine("Mogelijke commando's (1/2):");
                    Console.WriteLine("- shutdown (om een ACPI-shutdown te doen)");
                    Console.WriteLine("- reboot (opnieuw opstarten met de CPU)");
                    Console.WriteLine("- clear (om de console leeg te maken)");
                    Console.WriteLine("- cd .. (om naar de bovenliggende map te navigeren)");
                    Console.WriteLine("- cd (om te navigeren naar een folder)");
                    Console.WriteLine("- dir (geeft een weergave van mappen en bestanden)");
                    Console.WriteLine("- ls (geeft een weergave van mappen en bestanden)");
                    Console.WriteLine("- cp (om een bestand naar een andere bestemming te kopiëren)");
                    Console.WriteLine("- mkdir (om een map te maken");
                    Console.WriteLine("- rmdir (om een map te verwijderen)");
                    Console.WriteLine("- mkfil (om een bestand aan te maken)");
                    Console.WriteLine("- rmfil (om een bestand te verwijderen)");
                    Console.WriteLine("- edit (om een bestand te bewerken)");
                    Console.WriteLine("- vol (geeft een lijst met volumes)");
                    Console.WriteLine("- echo (om tekst te echoën)");
                    Console.WriteLine("- systeminfo (om systeeminformatie te weergeven)");
                    Console.WriteLine("- ver (om de systeemversie weer te geven)");
                    Console.WriteLine("- settings {argumenten} (toegang tot instellingen)");
                    Console.WriteLine("- logout (om los te koppelen)");

                    Console.ReadKey(); //page 2 (19 elements per page)

                    Console.WriteLine();
                    Console.WriteLine("Mogelijke commando's (2/2):");
                    Console.WriteLine("- time (om tijd en datum te verkrijgen)");
                    Console.WriteLine("- ipconfig (om netwerk informatie te verkrijgen)");
                    Console.WriteLine("- snake (start het spel Snake)");
                    Console.WriteLine("- md5 (om de hash van argumenten weer te geven)");
                    Console.WriteLine("- crash (crasht Aura)");
                    Console.WriteLine("- crashcpu (crasht CPU)");
                    Console.WriteLine("- lspci (lijst pci-apparaten)");
                    Console.WriteLine("- beep (beep)");

                    Console.ReadKey();

                    break;
            }
        }

        /// <summary>
        /// Display help on settings commands.
        /// </summary>
        public static void Settings()
        {
            switch (Kernel.langSelected)
            {
                case "fr_FR":
                    Console.WriteLine("Commandes disponible:");
                    Console.WriteLine("- adduser {user} {pass} (pour créer un compte)");
                    Console.WriteLine("- remuser {user} (pour supprimer un compte)");
                    Console.WriteLine("- passuser {user} {pass} (pour changer le mot de passe)");
                    Console.WriteLine("- setcomputername (pour changer le nom de l'ordinateur)");
                    Console.WriteLine("- setlang {lang} (pour changer la langue du système)");
                    break;

                case "en_US":
                    Console.WriteLine("Available commands:");
                    Console.WriteLine("- adduser {user} {pass} (to create an account)");
                    Console.WriteLine("- remuser {user} (to remove an account)");
                    Console.WriteLine("- passuser {user} {pass} (to change password)");
                    Console.WriteLine("- setcomputername (to change the computer name)");
                    Console.WriteLine("- setlang {lang} (to change the system language)");
                    break;

                case "nl_NL":
                    Console.WriteLine("Mogelijke commando's:");
                    Console.WriteLine("- adduser {gebruiker} {wachtwoord} (om een account aan te maken)");
                    Console.WriteLine("- remuser {gebruiker} (om een account te verwijderen)");
                    Console.WriteLine("- passuser {gebruiker} {wachtwoord} (om het wachtwoord te veranderen)");
                    Console.WriteLine("- setcomputername (om de naam van de computer te veranderen)");
                    Console.WriteLine("- setlang {lang} (om de systeemtaal aan te passen)");
                    break;
            }
        }

        /// <summary>
        /// Display help on settings commands.
        /// </summary>
        public static void Systeminfo()
        {
            switch (Kernel.langSelected)
            {
                case "fr_FR":
                    Console.WriteLine("Nom du PC:                     " + Kernel.ComputerName);
                    Console.WriteLine("Nom du système d'exploitation: Aura");
                    Console.WriteLine("Version du système:            " + Kernel.version);
                    Console.WriteLine("Révision du système:           " + Kernel.revision);
                    Console.WriteLine("Nom de la version:             " + Kernel.version_name_code);
                    Console.WriteLine("Date et heure:                 " + Time.MonthString() + "/" + Time.DayString() + "/" + Time.YearString() + ", " + Time.TimeString(true, true, true));
                    if (Kernel.SystemExists)
                    {
                        Console.WriteLine("Date d'installation originale: " + Utils.Settings.GetValue("setuptime"));
                    }
                    Console.WriteLine("Heure de démarrage du système: " + Kernel.boottime);
                    Console.WriteLine("Montant de la RAM:             " + Cosmos.Core.CPU.GetAmountOfRAM() + "MB");
                    Console.WriteLine("Processeur(s):                 " + Computer.Info.GetNumberOfCPU() + " processeur(s) installé(s).");
                    int i = 1;
                    foreach (Processor processor in Computer.CPUInfo.Processors)
                    {
                        Console.WriteLine("[" + i + "] : " + processor.GetBrandName() + (int)processor.Frequency + " Mhz");
                        i++;
                    }
                    Computer.CPUInfo.Processors.Clear();
                    break;

                case "en_US":
                    Console.WriteLine("Computer name:             " + Kernel.ComputerName);
                    Console.WriteLine("Operating system name:     Aura");
                    Console.WriteLine("Operating system version:  " + Kernel.version);
                    Console.WriteLine("Operating system revision: " + Kernel.revision);
                    Console.WriteLine("Version name:              " + Kernel.version_name_code);
                    Console.WriteLine("Date and time:             " + Time.MonthString() + "/" + Time.DayString() + "/" + Time.YearString() + ", " + Time.TimeString(true, true, true));
                    if (Kernel.SystemExists)
                    {
                        Console.WriteLine("Original Install Date:     " + Utils.Settings.GetValue("setuptime"));
                    }
                    Console.WriteLine("System Boot Time:          " + Kernel.boottime);
                    Console.WriteLine("Amount of RAM:             " + Cosmos.Core.CPU.GetAmountOfRAM() + "MB");
                    Console.WriteLine("Processor(s):              " + Computer.Info.GetNumberOfCPU() + " installed processor(s).");
                    int j = 1;
                    foreach (Processor processor in Computer.CPUInfo.Processors)
                    {
                        Console.WriteLine("[" + j + "] : " + processor.GetBrandName() + (int)processor.Frequency + " Mhz");
                        j++;
                    }
                    Computer.CPUInfo.Processors.Clear();
                    break;

                case "nl_NL":
                    Console.WriteLine("Naam computer:             " + Kernel.ComputerName);
                    Console.WriteLine("Naam besturingssysteem:    Aura");
                    Console.WriteLine("Versie besturingssysteem:  " + Kernel.version);
                    Console.WriteLine("Revisie besturingssysteem: " + Kernel.revision);
                    Console.WriteLine("Naam versie:               " + Kernel.version_name_code);
                    Console.WriteLine("Datum en tijd:             " + Time.MonthString() + "/" + Time.DayString() + "/" + Time.YearString() + ", " + Time.TimeString(true, true, true));
                    if (Kernel.SystemExists)
                    {
                        Console.WriteLine("Installeer datum:          " + Utils.Settings.GetValue("setuptime"));
                    }
                    Console.WriteLine("Starttijd van het systeem: " + Kernel.boottime);
                    Console.WriteLine("Hoeveelheid RAM:           " + Cosmos.Core.CPU.GetAmountOfRAM() + "MB");
                    Console.WriteLine("Processor(s):              " + Computer.Info.GetNumberOfCPU() + " processor(s) geïnstalleerd.");
                    int k = 1;
                    foreach (Processor processor in Computer.CPUInfo.Processors)
                    {
                        Console.WriteLine("[" + k + "] : " + processor.GetBrandName() + (int)processor.Frequency + " Mhz");
                        k++;
                    }
                    Computer.CPUInfo.Processors.Clear();
                    break;
            }
        }

    }
}
