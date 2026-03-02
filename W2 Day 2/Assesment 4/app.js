import {
  addTaskCallback,
  deleteTaskCallback,
  listTasksCallback
} from "./storage.js";

addTaskCallback("Learn JS", (message) => {
  console.log(message);

  listTasksCallback((tasks) => {
    console.log(`Current Tasks: ${tasks}`);

    deleteTaskCallback("Learn JS", (msg) => {
      console.log(msg);

      listTasksCallback((updated) => {
        console.log(`Updated Tasks: ${updated}`);
      });
    });

  });

});