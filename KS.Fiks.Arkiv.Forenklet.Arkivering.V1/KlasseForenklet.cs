﻿using System;

namespace KS.Fiks.IO.Arkiv.Client.ForenkletArkivering {
	/// <summary>
	/// Et klassifikasjonssystem er bygd opp av klasser. Ved funksjonsbasert
	/// (emnebasert)
	/// klassifikasjon vil klassene vanligvis inngå i et hierarki, hvor tre eller fire
	/// nivåer er det vanlige.
	/// I den konseptuelle modellen er undernivåene kalt underklasser, og fremkommer
	/// som en egenrelasjon i Klasse5.
	/// 
	/// ISO 15489 anbefaler at klassene beskriver organets funksjoner og aktiviteter
	/// (forretningsprosesser). Øverste nivå vil da typisk beskrive hovedfunksjonene,
	/// nivå to kan beskrive underfunksjoner og nivå tre prosessene (dvs. aktiviteter
	/// som stadig gjentas).
	/// 
	/// Klassene skal ha en egen identifikasjon som er unik innenfor
	/// klassifikasjonssystemet. Dette tilsvarer det som er kalt ordningsverdi eller
	/// arkivkode i Noark-4. Identifikasjoner fra overordnede klasser skal arves
	/// nedover i hierarkiet, slik at det er lett å si hvilket nivå en befinner seg
	/// på6
	/// </summary>
	public class KlasseForenklet {

		/// <summary>
		/// Definisjon: Entydig identifikasjon av klassen innenfor klassifikasjonssystemet.
		/// Andre klassifikasjonssystemer innenfor samme arkivsystem kan imidlertid
		/// inneholde en eller flere av de samme identifikasjonene. Identifikasjonen kan
		/// være rent nummerisk, men kan også være alfanumerisk og ha et logisk
		/// meningsinnhold. Merk at klasseID er identisk med begrepene ordningsverdi og
		/// arkivkode i Noark 4.
		/// 
		/// Kilde: Alle klasser i et klassifikasjonssystem opprettes vanligvis når et
		/// arkivsystem tas i bruk. Men enkelte løsninger kan tillate at det opprettes nye
		/// klasser ved behov (mest aktuelt ved objektbasert klassifikasjon).
		/// 
		/// Kommentarer: Eksempel på klasseID og tittel i tre nivåer fra statens
		/// arkivnøkkel (emne-/funksjonsbasert klassifikasjonssystem):
		/// 2 Stillinger og personell
		/// 2.3 Lønn og pensjon
		/// 2.3.6 Arbeidsgiveravgift
		/// Ved personbasert klassifikasjonssystem, kan f.eks. fødselsnummer og navn
		/// utgjøre klasseID og tittel.
		/// 
		/// M002
		/// </summary>
		public string klasseID;
		public string klassifikasjonssystem;
		/// <summary>
		/// klU1 i n4
		/// </summary>
		public Boolean skjermetKlasse;
		public string tittel;
	}
}