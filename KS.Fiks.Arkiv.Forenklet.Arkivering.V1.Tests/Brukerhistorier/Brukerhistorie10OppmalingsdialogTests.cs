﻿using System;
using KS.Fiks.Arkiv.Forenklet.Arkivering.V1.Helpers;
using KS.Fiks.Arkiv.Models.V1.Arkivstruktur;
using KS.Fiks.Arkiv.Models.V1.Innsyn.Sok;
using NUnit.Framework;

namespace KS.Fiks.Arkiv.Forenklet.Arkivering.V1.Tests.Brukerhistorier 
{
    class Brukerhistorie10OppmalingsdialogTests
    {
        // Skal sjekke om det finnes en sak med angitt saksår og saksseksvensnummer i akrivet
        [Test]
        public void SjekkSakMedSaksnummerFinnesGirValidXml()
        {
            var saksaar = 2020;
            var saksaksekvensnummer = 123;

            var arkivmeldingsok = new Sok
            {
                Respons = Respons.Saksmappe,
                MeldingId = Guid.NewGuid().ToString(),
                System = "Fagsystem X",
                Tidspunkt = DateTime.Now,
                Skip = 0,
                Take = 100,
                ResponsType = ResponsType.Utvidet
            };

            arkivmeldingsok.Parameter.Add(
            new Parameter
                {
                    Felt = SokFelt.SakPeriodSaksaar,
                    Operator = OperatorType.Equal,
                    Parameterverdier = new Parameterverdier
                    {
                        Intvalues = { saksaar }
                    }
                });
            
            arkivmeldingsok.Parameter.Add(
            new Parameter
                {
                    Felt = SokFelt.SakPeriodSaksekvensnummer,
                    Operator = OperatorType.Equal,
                    Parameterverdier = new Parameterverdier
                    {
                        Intvalues = { saksaksekvensnummer }
                    }
                });

            var payload = ArkivmeldingSerializeHelper.Serialize(arkivmeldingsok);
            Assert.True(Validator.IsValidSokXml(payload), "Validation errors");
        }
    }
}