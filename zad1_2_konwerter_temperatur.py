def zad2():
    print("Konwerter Temperatur")
    print("[c] Celsjusz -> Fahrenheit")
    print("[f] Fahrenheit -> Celsjusz")
    choice = input("Wybierz kierunek konwersji:")
    
    if choice not in ["f", "c"]:
        print("Nieprawidlowy wybór")
        return
    temp = int(input("Podaj temperature: "))

    if choice == "f":
        temp2 = (temp - 32) / 1.8
        print(f"{temp}°F = {temp2}°C")
    else:
        temp2 = temp * 1.8 + 32
        print(f"{temp}°C = {temp2}°F")

zad2()
