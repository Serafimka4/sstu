const express = require('express')
const app = express()
var cors = require('cors')
const { MongoClient } = require("mongodb")
       var ObjectId = require('mongodb').ObjectId;

const port = 4000

const client = new MongoClient("mongodb+srv://user:user@cluster0.5ksjv.mongodb.net/myFirstDatabase?retryWrites=true&w=majority", {
  useNewUrlParser: true,
  useUnifiedTopology: true,
})

client.connect((err, connection) => {
  if (err || !connection)
    console.error(err)

  console.log("Successfully connected to MongoDB.")

  const db = client.db('students')
  const studentsCollection = db.collection('students')
  const groupsCollection = db.collection('groups')

  app.use(express.json())
  app.use(cors())
  app.use(function (req, res, next) {
    console.log('Time:', Date.now())
    next()
  })

  app.post('/addStudent', (req, res) => {
    studentsCollection.insertOne(req.body).then(result => {
      console.log(result)
    })
    .catch(error => console.error(error))
  })

  app.post('/addGroup', (req, res) => {
    groupsCollection.insertOne(req.body).then(result => {
      console.log(result)
    })
    .catch(error => console.error(error))
  })

  app.get('/getStudents', (req, res) => {
    studentsCollection.find().toArray()
    .then(results => {
      results.forEach((r) => r.id = r._id)
      res.json(results)
    })
    .catch(error => console.error(error))
  })

  app.get('/getGroups', (req, res) => {
    groupsCollection.find().toArray()
    .then(results => {
      results.forEach((r) => r.id = r._id)
      res.json(results)
    })
    .catch(error => console.error(error))
  })

  app.post('/deleteStudent', (req, res) => {
    studentsCollection.deleteOne(
      { _id: new ObjectId(req.body.id) }
    )
      .then(result => {
        res.status(200)
      })
      .catch(error => console.error(error))
  })

  app.post('/deleteGroup', (req, res) => {
    groupsCollection.deleteOne({ _id: new ObjectId(req.body.id) })
      .then(result => {
        studentsCollection.deleteMany({ group_id: req.body.id })
          .then(result => { res.status(200) })
          .catch(error => console.error(error))
      }).catch(error => console.error(error))
  })

  app.post('/updateStudent', (req, res) => {
    studentsCollection.findOneAndUpdate(
      { _id: new ObjectId(req.body.id) },
      {
        $set: {
          name: req.body.s.name,
          age: req.body.s.age,
          type: req.body.s.type,
          avg_grade: req.body.s.avg_grade,
          group_id: req.body.s.group_id
        }
      },
      {
        upsert: false
      }
    )
      .then(result => {results => {
        console.log(results)
        res.json(results)
      }})
      .catch(error => console.error(error))

    res.status(200)
  })

  app.post('/updateGroup', (req, res) => {
    groupsCollection.findOneAndUpdate(
      { _id: new ObjectId(req.body.id) },
      {
        $set: {
          name: req.body.g.name,
          type: req.body.g.type,
          course: req.body.g.course,
        }
      },
      {
        upsert: true
      }
    )
      .then(result => {results => {
        console.log(results)
        res.json(results)
      }})
      .catch(error => console.error(error))

    res.status(200)
  })

  app.listen(port, () => {
    console.log(`Example app listening at http://localhost:${port}`)
  })
})
