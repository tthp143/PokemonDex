namespace PokemonDex
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonsList = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Charizard Charizard = new Charizard();
            this.pokemonsList.Add(Charizard);
            this.displayPokemon(Charizard);

        }

        private void displayPokemon(Pokemon pokemon)
        {
            this.pictureBox1.Text = pokemon.Name;
            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);
            }
            if (pokemon.Type2 == PokemonType.None)
            {
                this.Type2_dis.Visible = false;
            }
            else
            {
                this.Type2_dis.Visible = true;
            }
            this.Name_dis.Text = pokemon.Name;
            this.Type_dis.Text = pokemon.Type.ToString();
            this.Type2_dis.Text = pokemon.Type2.ToString();
            this.Hp_dis.Text = pokemon.HP.ToString();
            this.At_dis.Text = pokemon.Attack.ToString();
            this.Df_dis.Text = pokemon.Defense.ToString();
            this.SPAt_dis.Text = pokemon.SpecialAttack.ToString();
            this.SPDf_dis.Text = pokemon.SpecialDefense.ToString();
            this.Speed_dis.Text = pokemon.Speed.ToString();
            this.Total_dis.Text = pokemon.Total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Charizard Charizard = new Charizard();
            this.pokemonsList.Add(Charizard);
            this.displayPokemon(Charizard);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eevee Eevee = new Eevee();
            this.pokemonsList.Add(Eevee);
            this.displayPokemon(Eevee);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rookidee Rookidee = new Rookidee();
            this.pokemonsList.Add(Rookidee);
            this.displayPokemon(Rookidee);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mewtwo Mewtwo = new Mewtwo();
            this.pokemonsList.Add(Mewtwo);
            this.displayPokemon(Mewtwo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pikachu Pikachu = new Pikachu();
            this.pokemonsList.Add(Pikachu);
            this.displayPokemon(Pikachu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Snorlax Snorlax = new Snorlax();
            this.pokemonsList.Add(Snorlax);
            this.displayPokemon(Snorlax);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }


}
