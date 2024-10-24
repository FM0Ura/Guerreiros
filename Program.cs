namespace Guerreiros;

class Program
{
    /* Anel  */
    static void Main(string[] args)
    {
        /** Instanciando armas **/
        Guerreiros.ArmaduraFerro armaduraFerro = new Guerreiros.ArmaduraFerro();
        Guerreiros.ArmaduraAngelical armaduraAngelical = new Guerreiros.ArmaduraAngelical();
        Guerreiros.EspadaFerro espadaFerro = new Guerreiros.EspadaFerro();
        Guerreiros.EspadaFlamejante espadaFlamejante = new Guerreiros.EspadaFlamejante();
        Guerreiros.AnelDaAlma anelDaAlma = new Guerreiros.AnelDaAlma();


        Guerreiros.Guerreiro guerreiroImperial = new Guerreiros.Guerreiro();
        
        guerreiroImperial.equiparArma(espadaFerro);
        guerreiroImperial.equiparArmadura(armaduraFerro);
        guerreiroImperial.equiparAnel(anelDaAlma);
        anelDaAlma.


        Guerreiros.Guerreiro guerreiroNordico = new Guerreiros.Guerreiro();
        
        guerreiroNordico.equiparArma(espadaFlamejante);
        guerreiroNordico.equiparArmadura(armaduraAngelical);
        guerreiroImperial.Atacar(guerreiroNordico);
        guerreiroNordico.Atacar(guerreiroImperial);
    }
}
