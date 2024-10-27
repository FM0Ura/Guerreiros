namespace Guerreiros
{
    abstract class GuerreiroAbstrato
    {
        float HP = 100;

        float DEF;

        float ATK;

        float REFLEC = 0;

        public void Atacar(GuerreiroAbstrato guerreiro)
        {
            float dano = this.ATK - ((int) guerreiro.DEF * 0.25f);
            
            if(guerreiro.REFLEC != 0.0f){
                float danoAlvo = dano - guerreiro.REFLEC;
                float danoAtacante = guerreiro.REFLEC;

                this.HP -= danoAtacante;
                guerreiro.HP -= danoAlvo;
                
                Console.WriteLine($"Atacando, causando dano de {danoAlvo}. Inimigo com {guerreiro.HP} de vida, a armadura reduzio o ataque em {guerreiro.DEF * 0.25f}");
                Console.WriteLine($"O Alvo possui anel, {danoAtacante} foram refletidos para você. Você está com {this.HP}.");
            } else
            {
                guerreiro.HP -= dano;
                Console.WriteLine($"Atacando, causando dano de {dano}. Inimigo com {guerreiro.HP} de vida, a armadura reduzio o ataque em {this.ATK - dano}");
            }
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

        public void equiparAnel(AnelDecorator anel)
        {
            this.REFLEC = REFLEC + anel.REFLEC;
            Console.WriteLine($"Equipando anel, agora com {this.REFLEC} de refletir dano");
        }
    }
}