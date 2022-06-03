using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;

namespace KS.Fiks.Arkiv.Forenklet.Arkivering.V1.Tests
{
    public static class Validator
    {
        public static bool IsValidSokXml(string payload)
        {
            var validationHandler = new ValidationHandler();
            var xmlReaderSettings = new XmlReaderSettings();
            var arkivModelsAssembly = AppDomain.CurrentDomain.GetAssemblies()
                .SingleOrDefault(assembly => assembly.GetName().Name == "KS.Fiks.Arkiv.Models.V1");
            
            using (Stream schemaStream = arkivModelsAssembly.GetManifestResourceStream("KS.Fiks.Arkiv.Models.V1.Schema.V1.sok.xsd")) {
                using (XmlReader schemaReader = XmlReader.Create(schemaStream)) {
                    xmlReaderSettings.Schemas.Add("http://www.ks.no/standarder/fiks/arkiv/sok/v1", schemaReader);
                }
            }
            using (Stream schemaStream = arkivModelsAssembly.GetManifestResourceStream("KS.Fiks.Arkiv.Models.V1.Schema.V1.arkivstruktur.xsd")) {
                using (XmlReader schemaReader = XmlReader.Create(schemaStream)) {
                    xmlReaderSettings.Schemas.Add("http://www.arkivverket.no/standarder/noark5/arkivstruktur", schemaReader);
                }
            }
            using (Stream schemaStream = arkivModelsAssembly.GetManifestResourceStream("KS.Fiks.Arkiv.Models.V1.Schema.V1.metadatakatalog.xsd")) {
                using (XmlReader schemaReader = XmlReader.Create(schemaStream)) {
                    xmlReaderSettings.Schemas.Add("http://www.arkivverket.no/standarder/noark5/metadatakatalog/v2", schemaReader);
                }
            }
            xmlReaderSettings.ValidationType = ValidationType.Schema;
            xmlReaderSettings.ValidationEventHandler +=
                new ValidationEventHandler(validationHandler.HandleValidationError);

            var xmlReader = XmlReader.Create(new StringReader(payload), xmlReaderSettings);

            while (xmlReader.Read())
            {
            }

            return !validationHandler.HasErrors();
        }

        public static bool IsValidArkivmeldingXml(string payload)
        {
            var validationHandler = new ValidationHandler();
            var xmlReaderSettings = new XmlReaderSettings();
            var arkivModelsAssembly = AppDomain.CurrentDomain.GetAssemblies()
                .SingleOrDefault(assembly => assembly.GetName().Name == "KS.Fiks.Arkiv.Models.V1");
            
            using (Stream schemaStream = arkivModelsAssembly.GetManifestResourceStream("KS.Fiks.Arkiv.Models.V1.Schema.V1.arkivmelding.xsd")) {
                using (XmlReader schemaReader = XmlReader.Create(schemaStream)) {
                    xmlReaderSettings.Schemas.Add("http://www.arkivverket.no/standarder/noark5/arkivmelding/v2", schemaReader);
                }
            }
            using (Stream schemaStream = arkivModelsAssembly.GetManifestResourceStream("KS.Fiks.Arkiv.Models.V1.Schema.V1.metadatakatalog.xsd")) {
                using (XmlReader schemaReader = XmlReader.Create(schemaStream)) {
                    xmlReaderSettings.Schemas.Add("http://www.arkivverket.no/standarder/noark5/metadatakatalog/v2", schemaReader);
                }
            }
            using (Stream schemaStream = arkivModelsAssembly.GetManifestResourceStream("KS.Fiks.Arkiv.Models.V1.Schema.V1.arkivstruktur.xsd")) {
                using (XmlReader schemaReader = XmlReader.Create(schemaStream)) {
                    xmlReaderSettings.Schemas.Add("http://www.arkivverket.no/standarder/noark5/arkivstruktur", schemaReader);
                }
            }
            xmlReaderSettings.ValidationType = ValidationType.Schema;
            xmlReaderSettings.ValidationEventHandler +=
                new ValidationEventHandler(validationHandler.HandleValidationError);

            var xmlReader = XmlReader.Create(new StringReader(payload), xmlReaderSettings);

            while (xmlReader.Read())
            {
            }

            return !validationHandler.HasErrors();
        }
        
        
        public static bool IsValidArkivmeldingOppdateringXml(string payload)
        {
            var validationHandler = new ValidationHandler();
            var xmlReaderSettings = new XmlReaderSettings();
            var arkivModelsAssembly = AppDomain.CurrentDomain.GetAssemblies()
                .SingleOrDefault(assembly => assembly.GetName().Name == "KS.Fiks.Arkiv.Models.V1");
            
            using (Stream schemaStream = arkivModelsAssembly.GetManifestResourceStream("KS.Fiks.Arkiv.Models.V1.Schema.V1.arkivmelding.xsd")) {
                using (XmlReader schemaReader = XmlReader.Create(schemaStream)) {
                    xmlReaderSettings.Schemas.Add("http://www.arkivverket.no/standarder/noark5/arkivmelding/v2", schemaReader);
                }
            }
            
            using (Stream schemaStream = arkivModelsAssembly.GetManifestResourceStream("KS.Fiks.Arkiv.Models.V1.Schema.V1.arkivmeldingOppdatering.xsd")) {
                using (XmlReader schemaReader = XmlReader.Create(schemaStream)) {
                    xmlReaderSettings.Schemas.Add("http://www.arkivverket.no/standarder/noark5/arkivmeldingoppdatering/v2", schemaReader);
                }
            }
            
            using (Stream schemaStream = arkivModelsAssembly.GetManifestResourceStream("KS.Fiks.Arkiv.Models.V1.Schema.V1.metadatakatalog.xsd")) {
                using (XmlReader schemaReader = XmlReader.Create(schemaStream)) {
                    xmlReaderSettings.Schemas.Add("http://www.arkivverket.no/standarder/noark5/metadatakatalog/v2", schemaReader);
                }
            }
            
            xmlReaderSettings.ValidationType = ValidationType.Schema;
            xmlReaderSettings.ValidationEventHandler +=
                new ValidationEventHandler(validationHandler.HandleValidationError);

            var xmlReader = XmlReader.Create(new StringReader(payload), xmlReaderSettings);

            while (xmlReader.Read())
            {
            }

            return !validationHandler.HasErrors();
        }
    }
}