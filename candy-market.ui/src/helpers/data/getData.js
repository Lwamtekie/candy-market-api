import axios from 'axios';




const baseUrl = "http://localhost:60640";

const getallcandies = () => new promise((resolve, reject) => 
    axios.get(`${baseUrl}/candy`)
        .then((response) => 
            resolve(response.data) 
        )
        .catch(err => reject(err)) 


);

export default { getallcandies } 

