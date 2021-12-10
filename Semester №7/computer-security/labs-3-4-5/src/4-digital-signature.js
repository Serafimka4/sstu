import rsa from 'js-crypto-rsa'
import { readFileSync, writeFileSync} from 'fs'

// Inputs
const TARGET_FILE=`${process.env.DATA}/4-message`
const KEYPAIR_FILE=`${process.env.DATA}/3-keypair.json`

// Outputs
const SIGNATURE_FILE=`${process.env.DATA}/4-signature`

const main = async () => {
  // Import keys
  const { privateKey, publicKey } = JSON.parse(readFileSync(KEYPAIR_FILE))

  // Sign files
  const targetFileContent = readFileSync(TARGET_FILE)
  const signature = await rsa.sign(targetFileContent, privateKey)
  writeFileSync(SIGNATURE_FILE, signature)

  // Verify signature
  const signatureFileContent = readFileSync(SIGNATURE_FILE)
  const verified = await rsa.verify(targetFileContent, signatureFileContent, publicKey)

  if (verified)
    console.log("Signature is valid")
  else
    console.error("Signature is invalid")
}

main()
