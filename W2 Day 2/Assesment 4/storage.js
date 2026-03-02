// storage.js

let tasks = [];

// ADD TASK (Callback)
export const addTaskCallback = (task, callback) => {
  setTimeout(() => {
    tasks.push(task);
    callback(`Task "${task}" added successfully`);
  }, 1000);
};

// DELETE TASK (Callback)
export const deleteTaskCallback = (task, callback) => {
  setTimeout(() => {
    tasks = tasks.filter(t => t !== task);
    callback(`Task "${task}" deleted successfully`);
  }, 1000);
};

// LIST TASKS (Callback)
export const listTasksCallback = (callback) => {
  setTimeout(() => {
    callback(tasks);
  }, 1000);
};