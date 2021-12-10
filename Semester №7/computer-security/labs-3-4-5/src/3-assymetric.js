import rsa from 'js-crypto-rsa'
import xml from 'xml-js'
import md5File from 'md5-file'
import { writeFileSync, readFileSync } from 'fs'

// Inputs
const MESSAGE_FILE = `${process.env.DATA}/3-message`

// Outputs
const ENCRYPTED_FILE = `${process.env.DATA}/3-encrypted-file`
const DECRYPTED_FILE = `${process.env.DATA}/3-decrypted-file`
const KEYPARIR_XML = `${process.env.DATA}/3-keypair.xml`
const KEYPAIR_JSON = `${process.env.DATA}/3-keypair.json`

const main = async () => {
  // Generate keys
  const { privateKey, publicKey } = await rsa.generateKey(2048)

  // Export keys
  const json = JSON.stringify({ privateKey, publicKey })
  const xml__ = xml.json2xml(json, { compact: true, spaces: 4 })
  writeFileSync(KEYPARIR_XML, xml__)
  writeFileSync(KEYPAIR_JSON, json)

  // Encrypt file
  const secretFileContent = readFileSync(MESSAGE_FILE)
  const encryptedData = await rsa.encrypt(secretFileContent, publicKey, 'SHA-256')
  writeFileSync(ENCRYPTED_FILE, encryptedData)

  // Decrypt file
  const encryptedFileContent = readFileSync(ENCRYPTED_FILE)
  const decryptedData = await rsa.decrypt(encryptedFileContent, privateKey, 'SHA-256')
  writeFileSync(DECRYPTED_FILE, decryptedData)

  // Compare files
  const secretFileHash = md5File.sync(MESSAGE_FILE)
  const encryptedFileHash = md5File.sync(ENCRYPTED_FILE)
  const decryptedFileHash = md5File.sync(DECRYPTED_FILE)
  console.log(`${MESSAGE_FILE} ${secretFileHash}`)
  console.log(`${ENCRYPTED_FILE} ${encryptedFileHash}`)
  console.log(`${DECRYPTED_FILE} ${decryptedFileHash}`)
}

main()
