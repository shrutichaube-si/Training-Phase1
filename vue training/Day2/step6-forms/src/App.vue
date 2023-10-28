<template>
  <div class="container mt-5">
    <pre>{{ JSON.stringify(herodata, null, 1) }}</pre>
    <hr>

    <form>
      <div class="mb-3">
        <label for="htitle" class="form-label">Hero Title</label>
        <input type="text" class="form-control" id="htitle" v-model="herodata.title">
      </div>

      <div class="mb-3">
        <label for="hfname" class="form-label">Hero First Name</label>
        <input type="text" class="form-control" id="hfname" v-model="herodata.firstname">
      </div>

      <div class="mb-3">
        <label for="hlname" class="form-label">Hero Last Name</label>
        <input type="text" class="form-control" id="hlname" v-model="herodata.lastname">
      </div>

      <div class="mb-3">
        <label for="hpower" class="form-label">Hero Power</label>
        <input type="range" class="form-range" id="hpower" v-model="herodata.power">
      </div>

      <div class="mb-3">
        <label for="htype" class="form-label">Hero Type</label>
        <select id="htype" class="form-select" v-model="herodata.type">
          <option selected disabled value="">Select Here</option>
          <option value="avenger">Avenger</option>
          <option value="justiceleague">Justice League</option>
          <option value="indichero">Indic Hero</option>
        </select>
      </div>

      <div class="mb-3">
        <div class="form-check">
          <input class="form-check-input" type="checkbox" id="hcf1" v-model="herodata.canfight">
          <label class="form-check-label" for="hcf1">Can Fight</label>
        </div>
        <div class="form-check">
          <input class="form-check-input" type="checkbox" id="hcf2" v-model="herodata.fly">
          <label class="form-check-label" for="hcf2">Can Fly</label>
        </div>
      </div>

      <button type="submit" class="btn btn-primary">Submit</button>
    </form>
  </div>
</template>

<script>
export default {
  data() {
    return {
      title: "Welcome to VUE Training",
      herodata: {
        title: "",
        firstname: "",
        lastname: "",
        power: 0,
        type: "",
        canfight: false,
        fly: "can't fly"
      }
    };
  }
};
</script>

<style>
.container {
  max-width: 500px;
  margin: 0 auto;
  padding: 20px;
  border: 1px solid #ddd;
  border-radius: 10px;
  background-color: #f9f9f9;
  box-shadow: 0 5px 10px rgba(0, 0, 0, 0.1);
}

.form-label {
  font-weight: bold;
  color: #333;
}

.form-control,
.form-select {
  width: 100%;
  padding: 10px;
  margin-bottom: 15px;
  border: 1px solid #ccc;
  border-radius: 5px;
  background-color: #fff;
  transition: border-color 0.3s ease;
}

.form-control:focus,
.form-select:focus {
  border-color: #007bff;
  box-shadow: 0 0 5px rgba(0, 123, 255, 0.5);
}

.form-range {
  width: 100%;
}

.form-check {
  display: flex;
  align-items: center;
  color: #555;
}

.btn-primary {
  background-color: #007bff;
  color: white;
  border: none;
  border-radius: 5px;
  padding: 10px 20px;
  cursor: pointer;
  transition: background-color 0.3s ease;
}

.btn-primary:hover {
  background-color: #0056b3;
}

/* Add more color classes */
.bg-success {
  background-color: #28a745;
  color: white;
}

.bg-warning {
  background-color: #ffc107;
  color: #333;
}

.bg-danger {
  background-color: #dc3545;
  color: white;
}

/* Media query for responsiveness */
@media (max-width: 768px) {
  .container {
    max-width: 100%;
  }
}
</style>