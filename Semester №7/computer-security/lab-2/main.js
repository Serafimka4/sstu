const C = require("crypto-js")

const SECRET_TEXT = "Facilis incidunt totam rerum totam. Cumque assumenda quibusdam et cumque dicta praesentium voluptatem. Unde corrupti nostrum ea. Omnis dolor totam sed. Consectetur veritatis enim dolorem exercitationem eum accusantium ut. Minus nihil tempore cumque sed."
const PASSPHRASE = "aih0Zil5Vi0ahcah"
const REPEAT = 1000

function getTime(func) {
  const start = performance.now()
  func()
  const end = performance.now()
  return Number((end - start) / 1000).toFixed(2)
}

function stringifyMode(m) {
  switch (m) {
    case C.mode.ECB:
      return 'ECB'
    case C.mode.CFB:
      return 'CFB'
    case C.mode.CTR:
      return 'CTR'
  }
}

function stringifyCipher(c) {
  switch (c) {
    case C.AES:
      return 'AES'
    case C.DES:
      return 'DES'
    case C.Rabbit:
      return 'Rabbit'
    case C.RC4:
      return 'RC4'
  }
}

function bench(cipher, settings) {
  let encrypted
  const encrypt_time = getTime(() => {
    for (let i = 0; i < REPEAT; i++)
      encrypted = cipher.encrypt(SECRET_TEXT, PASSPHRASE, settings)
  })

  console.log(`${stringifyCipher(cipher)} ${stringifyMode(settings.mode)} ecnrypt: ${encrypt_time}`)

  const decrypt_time = getTime(() => {
    for (let i = 0; i < REPEAT; i++)
      cipher.decrypt(encrypted, PASSPHRASE, settings)
  })

  console.log(`${stringifyCipher(cipher)} ${stringifyMode(settings.mode)} decrypt: ${decrypt_time}`)

  return {
    time: (Number(encrypt_time) + Number(decrypt_time)) / 2,
    cipher: stringifyCipher(cipher)
  }
}

let results = []

results.push(bench(C.AES, { mode: C.mode.ECB, padding: C.pad.NoPadding }))
results.push(bench(C.AES, { mode: C.mode.CFB, padding: C.pad.NoPadding }))
results.push(bench(C.AES, { mode: C.mode.CTR, padding: C.pad.NoPadding }))
results.push(bench(C.DES, { mode: C.mode.ECB, padding: C.pad.NoPadding }))
results.push(bench(C.DES, { mode: C.mode.CFB, padding: C.pad.NoPadding }))
results.push(bench(C.DES, { mode: C.mode.CTR, padding: C.pad.NoPadding }))
results.push(bench(C.Rabbit, { mode: C.mode.ECB, padding: C.pad.NoPadding }))
results.push(bench(C.Rabbit, { mode: C.mode.CFB, padding: C.pad.NoPadding }))
results.push(bench(C.Rabbit, { mode: C.mode.CTR, padding: C.pad.NoPadding }))
results.push(bench(C.RC4, { mode: C.mode.ECB, padding: C.pad.NoPadding }))
results.push(bench(C.RC4, { mode: C.mode.CFB, padding: C.pad.NoPadding }))
results.push(bench(C.RC4, { mode: C.mode.CTR, padding: C.pad.NoPadding }))

results.sort((a, b) => {
  return a.time - b.time
})

for (const r of results)
  console.log(r.cipher, r.time)
