import mechanize

url = input("Enter the full url: ")
attack = 1

With open (‘vectors_XSS.txt’) as x:
        For line in x:
            browser.open(url)
        browser.select_form(nr = 0)
            browser[“id”] = line
        res = browser.submit()
            content = res.read()

        if content.find(line) > 0:
            print("Posible XSS")
        
        output = open('response/' + str(attack) + '.txt', 'w')
        output.write(content)
        output.close()
        print attack_no
        attack_no += 1