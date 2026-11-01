
with open("cipher.txt", "r") as file:
    lines = [i for i in file.readlines() if i != "\n"]
    print(lines)