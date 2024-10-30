namespace Guerreiros;

class Program
{
    /* Anel  */
    static void Main(string[] args)
    {
        /** Instanciando armas **/
        ArmaduraFerro armaduraFerro = new ArmaduraFerro();
        ArmaduraAngelical armaduraAngelical = new ArmaduraAngelical();
        EspadaFerro espadaFerro = new EspadaFerro();
        EspadaFlamejante espadaFlamejante = new EspadaFlamejante();
        AnelDaAlma anelDaAlma = new AnelDaAlma();
        EsferaDoDragao esferaDoDragao = new EsferaDoDragao();

        Guerreiro guerreiroImperial = new Guerreiro();
        
        guerreiroImperial.equiparArma(espadaFerro);
        guerreiroImperial.equiparArmadura(armaduraFerro);
        guerreiroImperial.equiparAnel(anelDaAlma);
        esferaDoDragao.aumentarPoderAnel(anelDaAlma);

        Guerreiro guerreiroNordico = new Guerreiro();
        
        guerreiroNordico.equiparArma(espadaFlamejante);
        guerreiroNordico.equiparArmadura(armaduraAngelical);
        
        // Atacando
        guerreiroImperial.Atacar(guerreiroNordico);
        guerreiroNordico.Atacar(guerreiroImperial);
    }
}
