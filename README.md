# ETHSLDWebScraping
This application developed to support for our ML project by collecting words and related video data of ETHSL(Ethiopian Sign Language) gesture
from our primary data source `http://ethsld.aau.edu.et`. The web application uses three main api endpoints to get it's data:
- `/ESLDS/public/api/Dictionary-Item/Word/{languageId}/{number_of_words}"`
- `/ESLDS/public/api/Get-RandWord-Detail2/{wordID}`
- `/ESLDS/public/assets/uploads/media_content/{fileName}`
