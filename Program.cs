using SerializarEdesserializarXML.ClasseXSD;
using System.Xml.Serialization;
class main
{
    public static void Main(String[] args)
    {

        /* 
        ClasseXMLGeneric xmlGeneric = new ClasseXMLGeneric();
        xmlGeneric.cod_beneficio = "codigo do beneficio ";
        xmlGeneric.cod_evento = "codigo do evento";
        xmlGeneric.cod_irrf = "codigo do irrf";
        XmlSerializer xml = new XmlSerializer(xmlGeneric.GetType());
        
         xml.Serialize(Console.Out, xmlGeneric);
       // Console.Out.Flush();
        Console.WriteLine();
        Console.Read();
        */

        ////Proxima requisição

        // Instancias 

        EventoIRRFBeneficio eventoIrrfBeneficio = new EventoIRRFBeneficio();

        eventoIrrfBeneficio.GerarXML();


        Console.WriteLine("Continuar.... Press Enter");
        Console.Read();
    }
}


class EventoIRRFBeneficio
{

    public void GerarXML()
    {
        //----------- Instancias do XML - evtIrrfBenef ---------------//
            eSocial esocial = new eSocial();
            eSocialEvtIrrfBenef esocialEventoIrrBeneficio = new eSocialEvtIrrfBenef();
            eSocialEvtIrrfBenefIdeEvento esocialEvtIrrfBenefIdeEvento = new eSocialEvtIrrfBenefIdeEvento();
            T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
            eSocialEvtIrrfBenefIdeTrabalhador esocialEvtIrrfBenefIdeTrabalhador = new eSocialEvtIrrfBenefIdeTrabalhador();
            eSocialEvtIrrfBenefIdeTrabalhadorDmDev esocialEvtIrrfBenefIdeTrabalhadorDmDev = new eSocialEvtIrrfBenefIdeTrabalhadorDmDev();
            eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIR esocialEvtIrrfBenefIdeTrabalhadorDmDevInfo = new eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIR();
            eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIRTpInfoIR esocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIRTpInfoIR = new eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIRTpInfoIR();
            eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurMen esocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurMen = new eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurMen();
        // ----------------------------------------------------------//

            esocial.evtIrrfBenef = esocialEventoIrrBeneficio;
            esocialEventoIrrBeneficio.ideEmpregador = t_ideEmpregador;
            esocialEventoIrrBeneficio.Id = "0";
            esocialEventoIrrBeneficio.ideEvento = esocialEvtIrrfBenefIdeEvento;
            esocialEventoIrrBeneficio.ideTrabalhador = esocialEvtIrrfBenefIdeTrabalhador;

            esocialEvtIrrfBenefIdeEvento.nrRecArqBase = "0";
            esocialEvtIrrfBenefIdeEvento.perApur = "0";

            t_ideEmpregador.nrInsc = "0";
            t_ideEmpregador.tpInsc = 0;

            esocialEvtIrrfBenefIdeTrabalhador.dmDev = new eSocialEvtIrrfBenefIdeTrabalhadorDmDev[0];
            esocialEvtIrrfBenefIdeTrabalhador.cpfBenef = "0";

            esocialEvtIrrfBenefIdeTrabalhadorDmDev.codCateg = "0";
            esocialEvtIrrfBenefIdeTrabalhadorDmDev.dtPgto = DateTime.Now;
            esocialEvtIrrfBenefIdeTrabalhadorDmDev.ideDmDev = "0";
            esocialEvtIrrfBenefIdeTrabalhadorDmDev.infoIR = new eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIR[0];
            esocialEvtIrrfBenefIdeTrabalhadorDmDev.perRef = "0";
            esocialEvtIrrfBenefIdeTrabalhadorDmDev.totApurDia = new eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurDia[0];
            esocialEvtIrrfBenefIdeTrabalhadorDmDev.totApurMen = new eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurMen[0];
            esocialEvtIrrfBenefIdeTrabalhadorDmDev.tpPgto = 0;

            esocialEvtIrrfBenefIdeTrabalhadorDmDevInfo.tpInfoIR = esocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIRTpInfoIR;
            esocialEvtIrrfBenefIdeTrabalhadorDmDevInfo.valor = 10;

            esocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIRTpInfoIR = eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIRTpInfoIR.Item11;

            esocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurMen.CRMen = TS_CRMen.Item056107;
            esocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurMen.vlrCRMen = 10;
            esocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurMen.vlrCRMenSusp = 10;
            esocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurMen.vlrCRMenSuspSpecified = true;

            XmlSerializer xml = new XmlSerializer(esocial.GetType());
             xml.Serialize(Console.Out, esocial);

 
      
    }
    
}