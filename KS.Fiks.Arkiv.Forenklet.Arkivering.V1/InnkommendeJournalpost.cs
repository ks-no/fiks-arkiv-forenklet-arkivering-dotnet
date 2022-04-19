﻿using System;
using System.Collections.Generic;

namespace KS.Fiks.IO.Arkiv.Client.ForenkletArkivering {
	public class InnkommendeJournalpost {

		
		//public Avskrivning avskriving;
		/// <summary>
		/// Definisjon: Dato som er påført selve dokumentet
		/// 
		/// Kilde: Datoen hentes automatisk fra dokumentet, eller registreres manuelt
		/// 
		/// Kommentar: Kan brukes både for inngående, utgående og organinterne dokumenter
		/// 
		/// M103 dokumentetsDato
		/// </summary>
		public DateTime? dokumentetsDato;
		/// <summary>
		/// Definisjon: Dato et eksternt dokument ble mottatt
		/// 
		/// Kilde: Registreres manuelt eller automatisk av systemet ved elektronisk
		/// kommunikasjon
		/// 
		/// Kommentar: Merk at mottattDato ikke behøver å være identisk med M600
		/// opprettetDato
		/// 
		/// M104 mottattDato
		/// </summary>
		public DateTime? mottattDato;
		/// <summary>
		/// jpInnhold i n4
		/// </summary>
		public string tittel;
		public ForenkletDokument hoveddokument;
		/// <summary>
		/// jpU1 i n4
		/// </summary>
		public Boolean skjermetTittel;
		/// <summary>
		/// Definisjon: Dato som angir fristen for når et inngående dokument må være
		/// besvart
		/// 
		/// Kilde: Registreres manuelt
		/// 
		/// Kommentar: Forfallsdato kan være angitt som en betingelse i det inngående
		/// dokumentet
		/// 
		/// M109 forfallsdato
		/// </summary>
		public DateTime? forfallsdato;
		/// <summary>
		/// jpOffinnhold i n4
		/// </summary>
		public string offentligTittel;
		/// <summary>
		/// Definisjon: Datoen da offentlighetsvurdering ble foretatt
		/// 
		/// Kilde: Registreres automatisk knyttet til funksjonalitet for skjerming
		/// 
		/// Kommentar: Dato for offentlighetsvurdering kan brukes dersom inngående
		/// dokumenter automatisk blir midlertidig skjermet ved mottak, og
		/// offentlighetsvurderingen skjer på et litt senere tidspunkt.
		/// 
		/// M110 offentlighetsvurdertDato
		/// </summary>
		public DateTime? offentlighetsvurdertDato;
		public SkjermingForenklet skjermingForenklet;

		public EksternNoekkelForenklet referanseEksternNoekkelForenklet;
		public List<ForenkletDokument> vedlegg;

		public List<KorrespondansepartForenklet> mottaker;
		public List<KorrespondansepartForenklet> avsender;

		public List<KorrespondansepartIntern> internMottaker;

		public InnkommendeJournalpost(){
			vedlegg = new List<ForenkletDokument>();
			mottaker = new List<KorrespondansepartForenklet>();
			avsender = new List<KorrespondansepartForenklet>();
			internMottaker = new List<KorrespondansepartIntern>();
		}
	}
}