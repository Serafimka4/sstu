const get = async (endpoint) => {
  const response = await fetch(`http://127.0.0.1:4000${endpoint}`)
  return await response.json()
}

const post = async (endpoint, json) => {
  await fetch(`http://127.0.0.1:4000${endpoint}`, {
    headers: { "Content-Type": "application/json" },
    method: 'POST',
    body: JSON.stringify(json)
  })
}

const getGroups = async () =>
  get("/getGroups")

const getStudents = async () =>
  get("/getStudents")

const deleteGroup = async (id) =>
  await post("/deleteGroup", { id: id })

const deleteStudent = async (id) =>
  await post("/deleteStudent", { id: id })

const updateGroup = async (id, g) =>
  await post("/updateGroup", { id: id, g: g })

const updateStudent = async (id, s) =>
  await post("/updateStudent", { id: id, s: s })

const addStudent = async (s) =>
  await post("/addStudent", s)

const addGroup = async (s) =>
  await post("/addGroup", s)

export { getGroups, getStudents, deleteGroup, deleteStudent, updateGroup, updateStudent, addStudent, addGroup }
