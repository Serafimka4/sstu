import steggy from 'steggy'
import fs from 'fs'
import md5File from 'md5-file'

// Inputs
const CARRIER_FILE = `${process.env.DATA}/5-carrier.png`
const PAYLOAD_FILE = `${process.env.DATA}/5-payload`
const PASSWORD = ".g5>=t]5f&{vWsP|:=u|"

// Outputs
const COVERT_MESSAGE_FILE = `${process.env.DATA}/5-covert-message.png`
const REVEALED_FILE = `${process.env.DATA}/5-revealed`

function main() {
  // Hide
  const carrierContent = fs.readFileSync(CARRIER_FILE)
  const payload = fs.readFileSync(PAYLOAD_FILE)
  const concealed = steggy.conceal(PASSWORD)(carrierContent, payload)
  fs.writeFileSync(COVERT_MESSAGE_FILE, concealed)

  // Reveal
  const covertMessageFileContent = fs.readFileSync(COVERT_MESSAGE_FILE)
  const revealed = steggy.reveal(PASSWORD)(covertMessageFileContent)
  fs.writeFileSync(REVEALED_FILE, revealed)

  // Compare
  const payloadHash = md5File.sync(PAYLOAD_FILE)
  const revealedHash = md5File.sync(REVEALED_FILE)
  console.log(`${PAYLOAD_FILE} ${payloadHash}`)
  console.log(`${REVEALED_FILE} ${revealedHash}`)
}

main()
