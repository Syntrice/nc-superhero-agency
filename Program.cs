using SuperheroAgency;

var reyzhen = new Mystic("Michael", "Reyzhen", 7000, Alignment.GOOD);
var rich = new Gadgeteer("Rich", "The Developer", 33, Alignment.EVIL);

var survey1 = new ReconMission<Gadgeteer>("Leeds", 300); // Should provide an error

var survey2 = new ReconMission<Mystic>("Manchester", 300);

survey2.HeroesDeployed.Add(reyzhen); // All good
survey2.HeroesDeployed.Add(rich); // Should provide an error
