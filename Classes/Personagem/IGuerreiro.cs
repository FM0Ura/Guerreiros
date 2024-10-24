namespace Guerreiros
{
    interface IGuerreiro
    {
        /** Métodos **/
        void Atacar(GuerreiroAbstrato guerreiro);
        void equiparArma(EspadaDecorator arma);
        void equiparArmadura(ArmaduraDecorator armadura);
        void equiparAnel(AnelDecorator anel);

    }
}