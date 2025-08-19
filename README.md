# ETHSLDWebScraping
### Introduction
This application developed to support for our ML project by collecting words and related video data of ETHSL(Ethiopian Sign Language) gesture
from our primary data source `http://ethsld.aau.edu.et`. The web application uses three main api endpoints to get it's data:
- `/ESLDS/public/api/Dictionary-Item/Word/{languageId}/{number_of_words}"`
- `/ESLDS/public/api/Get-RandWord-Detail2/{wordID}`
- `/ESLDS/public/assets/uploads/media_content/{fileName}`

### Algorithm explanation
The program starts from requesting the whole words `3134` then for each words there will be an iteration to get the word
detail using the second endpoint by providing the `wordID`, and then in the response there is a `fileName` that is used to request a specific video
data using the third endpoint.
