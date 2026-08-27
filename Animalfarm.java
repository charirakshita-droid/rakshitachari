 
/** Base class for all animals on the farm. */
class Animal {
    private String animalName = "Generic Animal";

    protected String getAnimalName() {
        return animalName;
    }

    protected void setAnimalName(String name) {
        this.animalName = name;
    }

    void takecare() {
        System.out.println("Taking care of " + animalName);
    }

    void feedamt(int amt) {
        System.out.println("Feeding " + animalName + " with " + amt + " units of food.");
    }

    void feedtype(String type) {
        System.out.println("Feeding " + animalName + " with " + type + ".");
    }

    void vaccination() {
        System.out.println("Vaccinating " + animalName);
    }

    void vaccstatus(boolean status) {
        if (status) {
            System.out.println(animalName + " is vaccinated.");
        } else {
            System.out.println(animalName + " is not vaccinated.");
        }
    }
}

// Single Inheritance (Animal -> Cow)
class Cow extends Animal {
    Cow() {
        setAnimalName("Cow");
        takecare();
    }

    @Override
    void feedamt(int amt) {
        System.out.println("Feeding the Cow with " + amt + " units of hay.");
    }

    @Override
    void feedtype(String type) {
        System.out.println("Feeding the Cow with " + type + ".");
    }

    @Override
    void vaccination() {
        System.out.println("Vaccinating the Cow against common bovine diseases.");
    }

    @Override
    void vaccstatus(boolean status) {
        if (status) {
            System.out.println("The Cow is vaccinated.");
        } else {
            System.out.println("The Cow is not vaccinated.");
        }
    }

    void coworbull(boolean isBull) {
        if (isBull) {
            System.out.println("This Cow is a Bull.");
        } else {
            System.out.println("This Cow is a Female Cow.");
        }
    }
}

// Multilevel inheritance (Animal -> Cow -> Calf)
class Calf extends Cow {
    Calf() {
        setAnimalName("Calf");
        takecare();
    }

    void specialcare() {
        feedamt(3);
        System.out.println("Providing special care for the Calf, including warmth and nutrition.");
    }

    // Previously commented out — now implemented instead of silently inheriting Cow's version.
    @Override
    void feedamt(int amt) {
        System.out.println("Feeding the Calf with " + amt + " units of milk replacer.");
    }

    @Override
    void feedtype(String type) {
        System.out.println("Feeding the Calf with " + type + ".");
    }

    @Override
    void vaccination() {
        System.out.println("Vaccinating the Calf against common bovine diseases.");
    }

    @Override
    void vaccstatus(boolean status) {
        if (status) {
            System.out.println("The Calf is vaccinated.");
        } else {
            System.out.println("The Calf is not vaccinated.");
        }
    }
}

// Hierarchical inheritance (Animal -> Cow / Goat)
class Goat extends Animal {
    Goat() {
        setAnimalName("Goat");
        takecare();
    }

    @Override
    void feedamt(int amt) {
        System.out.println("Feeding the Goat with " + amt + " units of hay.");
    }

    @Override
    void feedtype(String type) {
        System.out.println("Feeding the Goat with " + type + ".");
    }

    @Override
    void vaccination() {
        System.out.println("Vaccinating the Goat against common caprine diseases.");
    }

    @Override
    void vaccstatus(boolean status) {
        if (status) {
            System.out.println("The Goat is vaccinated.");
        } else {
            System.out.println("The Goat is not vaccinated.");
        }
    }
}

// Multiple inheritance through interfaces (Cost, Revenue)
interface Cost {
    void calculateCost();
}

interface Revenue {
    void calculateRevenue();
}

class Farm {
    protected String farmName = "ABC Animal Farm";

    void farmDetails() {
        System.out.println("Farm Name: " + farmName);
    }
}

// Hybrid inheritance (Farm -> Profit implements Cost, Revenue)
class Profit extends Farm implements Cost, Revenue {

    private int cost = 5000;
    private int revenue = 8000;

    @Override
    public void calculateCost() {
        System.out.println("Farm Cost = " + cost);
    }

    @Override
    public void calculateRevenue() {
        System.out.println("Farm Revenue = " + revenue);
    }

    void calculateProfit() {
        int profit = revenue - cost;
        System.out.println("Farm Profit = " + profit);
    }
}

public class Animalfarm {
    public static void main(String[] args) {
        Cow cow = new Cow();
        cow.feedamt(5);
        cow.feedtype("grass");
        cow.vaccination();
        cow.vaccstatus(true);

        Calf calf = new Calf();
        calf.coworbull(false);
        calf.specialcare();
        calf.feedtype("milk replacer");
        calf.vaccination();
        calf.vaccstatus(false);

        Goat goat = new Goat();
        goat.feedamt(3);
        goat.feedtype("hay");
        goat.vaccination();
        goat.vaccstatus(true);

        Profit profit = new Profit();
        profit.farmDetails();
        profit.calculateCost();
        profit.calculateRevenue();
        profit.calculateProfit();
    }
}
