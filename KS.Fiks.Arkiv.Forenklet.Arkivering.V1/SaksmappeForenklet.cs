﻿using System;
using System.Collections.Generic;

namespace KS.Fiks.IO.Arkiv.Client.ForenkletArkivering {
	public class SaksmappeForenklet {

		/// <summary>
		/// Definisjon: Inngår i M003 mappeID. Viser året saksmappen ble opprettet.
		/// 
		/// Kilde: Registreres automatisk når saksmappen opprettes
		/// 
		/// Kommentar: Se kommentar under M012 sakssekvensnummer
		/// 
		/// M011 saksaar
		/// </summary>
		public int saksaar;
		/// <summary>
		/// Definisjon: Inngår i M003 mappeID. Viser rekkefølgen når saksmappen ble
		/// opprettet innenfor året.
		/// 
		/// Kilde: Registreres automatisk når saksmappen opprettes
		/// 
		/// Kommentar: Kombinasjonen saksår og sakssekvensnummer er ikke obligatorisk, men
		/// anbefales brukt i sakarkiver.
		/// 
		/// M012 sakssekvensnummer
		/// </summary>
		public int sakssekvensnummer;
		/// <summary>
		/// angir mappetype som blant annet kan brukes som hint til hva som ligger i
		/// virksomhetsspesifikkemetadata
		/// </summary>
		public Kode mappetype;
		/// <summary>
		/// Definisjon: Datoen saken er opprettet
		/// 
		/// Kilde: Settes automatisk til samme dato som M600 opprettetDato
		/// 
		/// Kommentar: (ingen)
		/// 
		/// M100 saksdato
		/// </summary>
		public DateTime? saksdato;
		/// <summary>
		/// Definisjon: Tittel eller navn på arkivenheten
		/// 
		/// Kilde: Registreres manuelt eller hentes automatisk fra innholdet i
		/// arkivdokumentet. Ja fra klassetittel dersom alle mapper skal ha samme tittel
		/// som klassen. Kan også hentes automatisk fra et fagsystem.
		/// 
		/// Kommentarer: For saksmappe og journalpost vil dette tilsvare "Sakstittel" og
		/// "Dokumentbeskrivelse". Disse navnene kan beholdes i grensesnittet.
		/// 
		/// M020
		/// </summary>
		public string tittel;
		/// <summary>
		/// Definisjon: Navn på avdeling, kontor eller annen administrativ enhet som har
		/// ansvaret for saksbehandlingen.
		/// 
		/// Kilde: Registreres automatisk f.eks. på grunnlag av innlogget bruker, kan
		/// overstyres
		/// 
		/// Kommentar: Merk at på journalpostnivå grupperes administrativEnhet sammen med
		/// M307 saksbehandler inn i korrespondansepart. Dette muliggjør individuell
		/// behandling når det er flere mottakere, noe som er særlig aktuelt ved
		/// organinterne dokumenter som skal følges opp.
		/// 
		/// M305 administrativEnhet
		/// </summary>
		public string administrativEnhet;
		public string referanseAdministrativEnhet;
		/// <summary>
		/// Definisjon: Offentlig tittel på arkivenheten, ord som skal skjermes er fjernet
		/// fra innholdet i tittelen (erstattet med ******)
		/// 
		/// Kommentarer: I løpende og offentlig journaler skal også offentligTittel være
		/// med dersom ord i tittelfeltet skal skjermes.
		/// 
		/// M025
		/// </summary>
		public string offentligTittel;
		
		/// <summary>
		/// Definisjon: Navn på person som er saksansvarlig
		/// 
		/// Kilde: Registreres automatisk på grunnlag av innlogget bruker eller annen
		/// saksbehandlingsfunksjonalitet (f.eks. saksfordeling), kan overstyres manuelt
		/// 
		/// Kommentar: (ingen)
		/// 
		/// M306 saksansvarlig
		/// </summary>
		public string saksansvarlig;
		public string referanseSaksansvarlig;
		/// <summary>
		/// Definisjon: Status til saksmappen, dvs. hvor langt saksbehandlingen har kommet.
		/// 
		/// 
		/// Kilde: Registreres automatisk gjennom forskjellig saksbehandlings-
		/// funksjonalitet, eller overstyres manuelt.
		/// 
		/// Kommentar: Saksmapper som avleveres skal ha status "Avsluttet" eller "Utgår".
		/// 
		/// M052 saksstatus
		/// </summary>
		public string saksstatus;
		/// <summary>
		/// Definisjon: Navn på person som avsluttet/lukket arkivenheten
		/// 
		/// Kilde: Registreres automatisk av systemet ved opprettelse av enheten
		/// 
		/// Kommentarer: (ingen)
		/// 
		/// M603
		/// </summary>
		public string avsluttetAv;
		/// <summary>
		/// saU1 i n4
		/// </summary>
		public Boolean skjermetTittel;
		public EksternNoekkelForenklet referanseEksternNoekkelForenklet;

		/// <summary>
		/// 
		/// </summary>
		public List<KlasseForenklet> klasse;
	}
}