namespace Guerreiros
{
    abstract class GuerreiroAbstrato
    {
        float HP = 100;

        float DEF;

        float ATK;

        public void Atacar(GuerreiroAbstrato guerreiro)
        {
            float dano = this.ATK - ((int) guerreiro.DEF * 0.25f);
            guerreiro.HP -= dano;

            Console.WriteLine($"Atacando, causando dano de {dano}. Inimigo com {guerreiro.HP} de vida, a armadura reduzio o ataque em {this.ATK - dano}");
        }

        public void equiparArmadura(ArmaduraDecorator armadura)
        {
            this.DEF = DEF+armadura.Defesa;
            Console.WriteLine($"Equipando armadura, agora com {this.DEF} de defesa");
        }

        public void equiparArma(EspadaDecorator arma)
        {
            this.ATK = ATK+arma.Ataque;
            Console.WriteLine($"Equipando arma, agora ataque com {this.ATK}");
        }

    }
}