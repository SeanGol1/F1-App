from selenium import webdriver
from selenium.webdriver.common.keys import Keys
import time

PATH = 'C:\Program Files (x86)\chromedriver.exe'
driver = webdriver.Chrome(PATH)

driver.get("https://d35nw2lg0ahg0v.cloudfront.net/result-or-voted")

search = driver.find_element_by_id("__layout")

time.sleep(5)

result = search.text
result1 = result.split('#')

print (result1[0])

time.sleep(0)

driver.quit()


insert = webdriver.Chrome(PATH)
insert.get("https://localhost:44341/home/contact/?driver=" + result1[0])
time.sleep(10)
insert.quit()


update = webdriver.Chrome(PATH)
update.get("https://localhost:44341/home/about")
time.sleep(10)
update.quit()

