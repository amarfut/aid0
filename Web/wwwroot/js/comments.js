class Comment {
    constructor(name, text) {
        this.name = name;
        this.created = 'секунду назад';
        this.text = text;
        this.likes = 0;
        this.dislikes = 0;
    }
}

function AppCommentModel() {
    let self = this;
    self.comments = ko.observableArray([]);
    self.answerBoxVisibe = ko.observable(false);

    self.addComment = function (postId, parentCommentId = null) {
        const commentBoxId = '#comment-box';
        var answerCommentBoxId = `#${parentCommentId}-comment-box`;
        const text = parentCommentId === null ? $(commentBoxId).val() : $(answerCommentBoxId).val();
        $(commentBoxId).val('');
        $(answerCommentBoxId).val('');

        console.log(text);
        $.ajax({
            url: '/comment/addcomment',
            type: 'POST',
            contentType: "application/json",
            data: JSON.stringify({
                Text: text,
                PostId: postId,
                ParentCommentId: parentCommentId
            }),
            success: (data) => {
                document.location.reload(true);
            },
            error: (error) => {
                console.log(error);
            }
        });
    };

    self.displayAnswerCommentBox = function (commentId, parentCommentId, isVisible, userName) {
        const answerId = parentCommentId ? parentCommentId : commentId;
        $('.asnwer-comment-box').hide();
        $('.asnwer-comment-box').val('');
        const answerComment = $('#' + answerId + '-asnwer-comment-box');
        if (isVisible) {
            if (parentCommentId) {
                $(`#${parentCommentId}-comment-box`).val('@' + userName + ', ');
            }
            answerComment.show();
        }
        else {
            answerComment.hide();
        }
    };

    self.setReaction = function (commentId, parentCommentId, currentReaction) {
        $.ajax({
            url: '/comment/setcommentreaction',
            type: 'POST',
            contentType: "application/json",
            data: JSON.stringify({
                ParentCommentId: parentCommentId,
                CommentId: commentId,
                Liked: currentReaction
            }),
            success: (data) => {
                $(`#${commentId}-likes`).text(data.likes);
                $(`#${commentId}-dislikes`).text(data.dislikes);
            },
            error: (error) => {
                console.log(error);
            }
        });
    };
}

ko.applyBindings(new AppCommentModel(), document.getElementById('post-comments-form'));



class UrlHelper {
    makePost(url, data) {
        $.ajax({
            url: url,
            type: 'POST',
            contentType: "application/json",
            data: JSON.stringify(data),
            success: (data) => {
               
            },
            error: (error) => {
               
            }
        });
    }
}