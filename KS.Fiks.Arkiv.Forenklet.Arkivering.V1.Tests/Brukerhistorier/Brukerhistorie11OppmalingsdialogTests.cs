using System;
using KS.Fiks.Arkiv.Forenklet.Arkivering.V1.Helpers;
using KS.Fiks.Arkiv.Models.V1.Innsyn.Sok;
using NUnit.Framework;

namespace KS.Fiks.Arkiv.Forenklet.Arkivering.V1.Tests.Brukerhistorier
{
    class UnitTestBrukerhistorie11Oppmalingsdialog
    {

        public void Setup()
        {
        }

        // fagsystem har dokumentID til dokumentet skal finne dokumentet for visnign i klient
        [Test]
        public void TestFinnDokumentFraId()
        {
            var dokumentEkstenId  = "12345-ABCDE";
          
            var arkivmeldingsok = new Sok
            {
                Respons = Respons.Dokumentbeskrivelse,
                MeldingId = Guid.NewGuid().ToString(),
                System = "Fagsystem X",
                Tidspunkt = DateTime.Now,
                Skip = 0,
                Take = 100
            };
            // må søke på ekstenID finner ikke noe felt for dokument id.

            var parameter = new Parameter
            {
                Felt = SokFelt.DokumentbeskrivelsePeriodEksternId,
                Operator = OperatorType.Equal,
                Parameterverdier = new Parameterverdier
                {
                    EksternId = new EksternId()
                    {
                        System = "Fagsystem X",
                        Id = dokumentEkstenId
                    }
                }
            };

            arkivmeldingsok.Parameter.Add(parameter);
            var payload = ArkivmeldingSerializeHelper.Serialize(arkivmeldingsok);
            Assert.True(Validator.IsValidSokXml(payload), "Validation errors");
        }
    }
}
