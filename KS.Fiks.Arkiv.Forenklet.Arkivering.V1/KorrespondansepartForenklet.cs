﻿using System;

namespace KS.Fiks.IO.Arkiv.Client.ForenkletArkivering {
	public class KorrespondansepartForenklet {

		/// <summary>
		/// Definisjon: Entydig identifikasjon av arkivenheten innenfor det
		/// arkivskapende organet. Dersom organet har flere arkivsystemer, skal altså
		/// systemID være gjennomgående entydig. Systemidentifikasjonen vil som oftest
		/// være en nummerisk kode uten noe logisk meningsinnhold. Identifikasjonen
		/// trenger ikke å være synlig for brukerne.
		/// 
		/// Kilde: Registreres automatisk av systemet
		/// 
		/// Kommentarer: Alle referanser fra en arkivenhet til en annen skal peke til
		/// arkivenhetens systemidentifikasjon. Dette gjelder også referanser fra en
		/// arkivdel til en annen, f.eks. mellom to arkivperioder som avleveres på
		/// forskjellig tidspunkt. I et arkivuttrekk skal systemID være entydig (unik).
		/// Dokumentobjekt har ingen systemidentifikasjon fordi enheten kan være
		/// duplisert i et arkivuttrekk dersom samme dokumentfil er knyttet til flere
		/// forskjellige registreringer.
		/// 
		/// M001
		/// </summary>
		public string systemID;
		public Enhetsidentifikator enhetsidentifikator;
		public Personidentifikator personid;
		/// <summary>
		/// Definisjon: Type korrespondansepart
		/// 
		/// Kilde: Registreres automatisk knyttet til funksjonalitet i forbindelse med
		/// opprettelse av journalpost, kan også registreres manuelt
		/// 
		/// Kommentarer: Korrespondansetype forekommer én gang innenfor objektet
		/// korrespondansepart, men denne kan forekomme flere ganger innenfor en
		/// journalpost.
		/// 
		/// M087
		/// </summary>
		public Kode korrespondanseparttype;
		public string navn;
		/// <summary>
		/// amU1 i n4
		/// </summary>
		public Boolean skjermetKorrespondansepart;
		public EnkelAdresse postadresse;
		public KontaktinformasjonForenklet kontaktinformasjonForenklet;
		public string kontaktperson;
		/// <summary>
		/// amRef i n4
		/// </summary>
		public string deresReferanse;
		/// <summary>
		/// amForsend i n4
		/// </summary>
		public string forsendelsemåte;
	}
}