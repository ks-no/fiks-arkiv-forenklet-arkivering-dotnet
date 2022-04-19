﻿using System;

namespace KS.Fiks.IO.Arkiv.Client.ForenkletArkivering {
	/// <summary>
	/// Skjerming benyttes til å skjerme registrerte opplysninger eller
	/// enkeltdokumenter. Skjermingen
	/// trer i kraft når en tilgangskode påføres den enkelte mappe, registrering eller
	/// det enkelte
	/// dokument. (Se NOARK 5 v3.1 eget kapittel: 6.6.1 Skjerming)
	/// </summary>
	public class SkjermingForenklet {

		/// <summary>
		/// Definisjon: Henvisning til hjemmel (paragraf) i offentlighetsloven,
		/// sikkerhetsloven eller beskyttelsesinstruksen
		/// 
		/// Kilde: Registreres automatisk på grunnlag av valgt tilgangskode, kan overstyres
		/// manuelt
		/// 
		/// Kommentarer: (ingen)
		/// 
		/// M501
		/// </summary>
		public string skjermingshjemmel;
		/// <summary>
		/// Definisjon: Antall år skjermingen skal opprettholdes.
		/// 
		/// Kilde: Registreres automatisk knyttet til valg av tilgangskode, kan registreres
		/// manuelt.
		/// 
		/// Kommentarer: Tidspunktet for når skjermingsvarigheten starter å løpe, vil
		/// vanligvis være når journalposten ble registrert, men det skal være mulig med
		/// andre regler.
		/// 
		/// M504
		/// </summary>
		public int skjermingsvarighet;
		/// <summary>
		/// Definisjon: Datoen skjermingen skal oppheves.
		/// 
		/// Kilde: Datoen beregnes automatisk på grunnlag av M504 skjermingsvarighet
		/// 
		/// Kommentarer: (ingen)
		/// 
		/// M505
		/// </summary>
		public DateTime skjermingOpphoererDato;

	}
}